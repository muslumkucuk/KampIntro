using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			// 2 Ayda müthiş programcı olunmaz. ! 
			// type safety - tip güvenliği
			// Do not repeat yourself - Asla kendini tekrarlama
			/* Programı dallandırma ---> Mesela sisteme giriş yapmış mı yapmamış mı?
			   Bu da boolean veri tipi ile tutulur. */

			string kategoriEtiketi = "Kategoriler";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = false;
			double dolarDun = 7.55;
			double dolarBugun = 7.45;


            if (dolarDun > dolarBugun)
            {
				Console.WriteLine("Azalış resmi");
            }
            else if (dolarDun<dolarBugun)
            {
				Console.WriteLine("Artış resmi");
            }
            else
            {
				Console.WriteLine("Değişmedi resmi");
            }


            if (sistemeGirisYapmisMi == true)
            {
				Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
				Console.WriteLine("Giriş Yap Butonu");
            }

			Console.WriteLine(kategoriEtiketi);

		}
	}
}
