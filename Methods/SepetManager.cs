using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi : "+urun.Adi);
             
        }
        public void Ekle2(string urunAd, string aciklama, double fiyat, int stockAdedi)
        {
            Console.WriteLine("Tebrikler! Ürün eklendi: "+urunAd);
        }
    }
}
