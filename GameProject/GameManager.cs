using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi: "+game.Name);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi: " + game.Name);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi: " + game.Name);
        }
    }
}
