using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double urunFiyatı = 15;
            string aciklama = "Amasya Elması";

            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            
            
            Console.WriteLine("---------Metotlar----------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil armut", 12);
            sepetManager.Ekle2("Elme", "Yeşil elma", 12);
            sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12);

        }
        
         
    }
}


// Don't repeat yourself - DRY - metotlarla ilgili clean code teknikleri önemli - Best practice