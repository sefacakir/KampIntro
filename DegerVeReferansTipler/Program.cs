using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;

            //sayi1 = 30;
            //sayi2 = 65 olur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] elemanı kaçtır?? 999

            //int, decimal, float, double, bool = değer tip
            //array, class, interface = referans tip 

            int sayi = 100;
            void Incele(int deger)
            {
                deger = 99;
            }
            Console.WriteLine(sayi);
            //int sayi = 100 bir değer tiptir.
            //sayi'nın değerini 100 olarak atadığımda tüm bağlantılar kopuyor.
            //şu ikisi birbirinin aynısı
            Incele(100);
            Incele(sayi);

            Product product = new Product();
            product.ProductName = "Masa";

            ProductManager productManager = new ProductManager();
            Console.WriteLine("Ürün ismi : "+product.ProductName);
            productManager.Incele(product);
            Console.WriteLine("Incele fonksiyonuna gönderildikten sonra ürün ismi : "+product.ProductName);
            
            /*
             Yukarıdaki örnekten yorumumuzu yaparsak;
            Incele fonksiyonuna gönderdiğimiz parametre "int",
            yani değer tiptir. Dolayısıyla Incele fonksiyonuna 100 sayısı
            gönderilmiş gibi düşünebiliriz.

            Incele fonksiyonuna gönderdiğimiz parametre "Product"
            yani bir classtır. Class'ın referans tip olduğunu biliyoruz.
            Dolayısıyla gönderdiğimiz product'ın bellek adresi gönderilmiş
            olur. Örneğin bellek adresi 101 olsun.
            Incele(product) dedik ve 101. bellek adresi gönderildi.
            Incele fonksiyonu içerisindeki product.ProductName = "Kamera"
            komut satırı, 101. bellek adersindeki product'ın ismini değiştirir.
            Dolayısıyla product'ımızın yeni ismi artık kamera olmuş olur.
             */
        }
    }

    class Product
    {
        public string ProductName { get; set; }
    }
    class ProductManager
    {
        public void Incele(Product product)
        {
            product.ProductName = "Kamera";
        }
    }
}
