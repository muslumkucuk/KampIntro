using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 36;

            Kurs Java = new Kurs();
            Java.KursAdi = "Java Programlamaya Giriş Kursu";
            Java.Egitmen = "Müslüm Küçük";
            Java.IzlenmeOrani = 98;

            Kurs Csharp = new Kurs();
            Csharp.KursAdi = "C# Programlamaya Giriş Kursu";
            Csharp.Egitmen = "Engin Demiroğ";
            Csharp.IzlenmeOrani = 92;

            Kurs Phyton = new Kurs();
            Phyton.KursAdi = "Phyton ile Programlamaya Giriş Kursu";
            Phyton.Egitmen = "Engin Demiroğ";
            Phyton.IzlenmeOrani = 92;

            Kurs[] kurslar = new Kurs[] { Java,Csharp,Phyton };

            foreach (var abc in kurslar)
            {
                Console.WriteLine(abc.KursAdi + abc.Egitmen);
            }

            // Console.WriteLine(java.KursAdi + " " + java.Egitmen );
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
        

}
