using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt oldu : "+gamer.FirstName);
            }
            else
            {
                Console.WriteLine("Doğrulama ve kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi : "+gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi : "+ gamer.FirstName);
        }
    }
}
