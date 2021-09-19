using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.FirstName = "Sefa";

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer1);

            Campaign campaign1 = new Campaign(); //sisteme kampanya eklendi.
            campaign1.CampaignName = "Bir Alana Bir Bedava";

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            Game game1 = new Game();
            game1.Name = "Counter Strike";

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(gamer1,campaign1,game1);
        }
    }
}
//Adım adım gidelim. Once nesnemi buldum. Gamer.
//Bir gamer class'ı oluşturdum ve içine bir kaç özellik ekledim.
//Ardından oyuncuları yöneten, silen, ekleyen, güncelleyen bir manager'a ihtiyacım var.
//Bu manager için hemen bir interface oluşturdum.
//Gerekli operasyonları interface yazdım. Ekle sil güncelle...
//manager interface'ı implemenets ediyor. Yani ondan miras alıyor.


//Hiçbir sınıf çıplak kalmayacak. Eğer bir class herhangi bir inheritance veya
//implementasyon almıyorsa sıkıntı vardır demek


//Mernis servisimiz için bir class oluşturucaz. Class oluşturmadan önce de
//interface'imizi oluşturucaz. Peki bu bize ne kazandıracak ?
//Eğer sisteme ilerde daha farklı bir kontrol sistemi gelirse
//hiçbir değişiklik yapmadan işlemlerimizi devam ettirebilmemiz için.

//Gerekli tamamlamaları yaptık.
//şimdi GamerManager sınıfında işlemler yaparken aynı zamanda
//kimlik doğrulaması yapmamız gerekiyor.
//Bir manager sınıfı içerisinde başka bir manager sınıf kullanmak üzereyiz.
//Bir manager sınıfı içerisinde başka bir manager sınıfını ASLA NEWLEME.

