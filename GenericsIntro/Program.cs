using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
            isimler.Add("Sefa");
            isimler.Add("Ahmet");
            isimler.Yazdir();
        }
    }
}
