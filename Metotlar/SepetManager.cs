using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        // naming convention - isimlendirme kuralı
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, ürününüz sepete Eklendi." + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double urunFiyatı)
        {
            Console.WriteLine("Tebrikler, ürününüz sepete Eklendi." + urunAdi);
            

        }
    }
}
