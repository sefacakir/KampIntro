using System;
using System.Collections.Generic;

namespace OOP3
{

    class Program
    {
        //interfaceler o sınıfı implemente eden class'ların referans
        //numarasını tutabilir.
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();

            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });

            /*
            ILoggerService fileLoggerService = new FileLoggerService();
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);
            */
            List<IKrediManager> krediler = new List<IKrediManager>() 
            {
                ihtiyacKrediManager,
                tasitKrediManager,
                konutKrediManager
                
            };

            //interfaceleri birbirinin alternatifi ama kod içeriği farklı olan
            //durumlarda kullanıyoruz.

            basvuruManager.BasvuruYap(new EsnafKrediManager(), new List<ILoggerService>{ new SmsLoggerService()});

            List<ILoggerService> loggers = new List<ILoggerService> {new FileLoggerService(), new DatabaseLoggerService(),new SmsLoggerService() };
            basvuruManager.KrediOnBilgilendirmesiYap(krediler, loggers);
        
        
        
        }
    }
}
