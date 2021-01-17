using System;
//class structures
namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Class yapısı intanceleri ");

            string adi = "Özer";
            int yas = 23;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "Python";
            kurs1.Egitmen = "Kerem Varıs";
            kurs1.izlenmeOrani = 35;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Berkay Bilgin";
            kurs2.izlenmeOrani = 80;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "C#";
            kurs3.Egitmen = "Engin Demirog";
            kurs3.izlenmeOrani = 35;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "C++";
            kurs4.Egitmen = "Murat Kurtboğan";
            kurs4.izlenmeOrani = 100;

            //  Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};
            foreach (var kurs in kurslar)//var yerine veri tipi olarak Kurs yazabiliriz
            {
                Console.WriteLine(kurs.KursAdi+":"+kurs.Egitmen);
            }*/

            /* //ternary operatörü
             int sayi1 = 32;
             int sayi2 = 34;
             int sayi3 = 55;
             //ternary operatörü yani tek satırda işlem kontrolü yapmayı saglayan operatördür
             Console.WriteLine(sayi1==sayi2 ? "Eşit" : sayi1+sayi2>sayi3 ? "evet büyük" : "Eşit değil bu sayılar bor :D ");
             Console.WriteLine(sayi2>sayi1 ? true : false);// true false yerine 1 -1 de dönebilir

             //ternary operator sonu
            */
            //switch yapısı :D 

            /*int gun = (int)DateTime.Now.DayOfWeek; // haftanın günlerini gösteren yapı
            switch (gun)
            {
                case 1:
                    Console.WriteLine("monday");
                    break;
                case 2:
                    Console.WriteLine("tuesday");
                    break;
                case 3:
                    Console.WriteLine("wednesday");
                    break;
                case 4:
                    Console.WriteLine("thursday");
                    break;
                case 5:
                    Console.WriteLine("friday");
                    break;
                case 6:
                    Console.WriteLine("saturday");
                    break;
                case 7:
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("wrong day bro!");
                    break;
            */
            //while döngüsü örnegi
            int sayi;
            while (true)
            {
                Console.WriteLine("sayi giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi%2==0) // çift ise yani iki ile bölümünden kalan 0 ise.
                {
                    Console.Write(" girdigin sayi çifttir");
                }
                sayi++;
            }
        }
    }
 
    class Kurs
    {
        //prop tab tab fonksiyon yazıyor 
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int izlenmeOrani { get; set; }

    }
}