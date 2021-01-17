using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yeni başlayanlar için java";
            string kurs2 = "Yeni başlayanlar için phyton";
            string kurs3 = "Yeni başlayanlar için C#";

            //array - dizi

            string[] kurslar = new string[] { "Yeni başlayanlar için java", "Yeni başlayanlar için phyton", "Yeni başlayanlar için C#" }; // İçinde string tutabildiğimiz dizi.


            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For döngüsü bitti..");

            Console.WriteLine("Sayfa sonu - footer");
           
        }
    }
}
