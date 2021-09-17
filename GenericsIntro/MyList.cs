using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {   //MyList'imde T ile çalışacağım anlamına geliyor. T=type
        //Bir tip gönderilecek. string, int, double, boolean, class,
        //product, vs vs buraya herşey gönderilebilir.

        
        T[] items;

        public MyList()
        {   //constructor
            //class newlendiğinde otomatik olarak çalışır.
            items = new T[0];

        }

        public void Add(T item)
        {
            T[] tempArray = items;
            //new'lediğimizde elemanların kaybolmaması için referans 
            //numarasını temp array'de tutuyoruz.

            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;
            
        }
        public void Yazdir()
        {
            for (int i = 0; i < items.Length; i++)
            {
                Console.WriteLine(items[i]);
            }
        }


    }
}
