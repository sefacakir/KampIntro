using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 20;

            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Sefa Çakır";
            kurs2.KursAdi = "Yazılım Geliştirme";
            kurs2.IzlenmeOrani = 30;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (Kurs item in kurslar)
            {
                Console.WriteLine(item.Egitmen);
                Console.WriteLine(item.IzlenmeOrani);
                Console.WriteLine(item.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani{ get; set; }
    }
}
