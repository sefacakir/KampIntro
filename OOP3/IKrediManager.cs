using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager
    {
        //interfacelerin başına I harfi gelmesi gerekir.
        //Hesapla fonksiyonu her kredi için ayrı ayrı çalışacaktır.
        //Her birinin faiz oranı vs ayrıdır.
        //imzanın aynı olduğu ve içeriğin farklı olduğu durumlarda
        //base'i class olarak değil, interface olarak belirleriz.
        //interface'i kullananlar, interface içerisindeki metotları
        //içermek zorundadır

        void Hesapla();
        void BiseyYap();
    }
}
