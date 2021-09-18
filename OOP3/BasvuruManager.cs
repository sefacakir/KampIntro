using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        //method injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            //şuanda tüm başvuruları konutKredi'sine bağlı yaptık.
            //bu hatalı bir durumdur.


            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler, List<ILoggerService> loggers)
        {
            //bu fonksiyonda birden fazla krediyi aynı anda hesaplamak için
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
                //listedeki her bir kredinin hesabını yapıyoruz.
                foreach (var log in loggers)
                {
                    log.Log();
                }
            }
        }








    }
}
