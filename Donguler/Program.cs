using System;
using System.Security;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            // manuel - static
            string kurs1 = "Yazılım geliştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";
            //dynamic listeleme
            //diziler- arrays
            string[] kurslar = new string[] { kurs1, kurs2, kurs3, kurs4, kurs5 }; //dizi tanımlama yapısı C# ta böyle yapılıyor
            foreach (var kurs in kurslar) // var: variable dizi temelli yapıları tek tek dolaşır
            {
                Console.WriteLine(kurs);
            }
            forLoop(kurslar);

            //döngüler örnekler
            int sayi = 0;
            while (sayi<10) // şartın içerisi dogru oldugu surece caLisir
            {
                Console.WriteLine(sayi);
                sayi++;
            }

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
            // foreach readonly bir looptur 
            do // genelde kullanılmıyor 
            {
                Console.WriteLine("bi kere çalıştı");
            } while (sayi<3);
            */



            //asal sayıları bulan kod blogu
            var result=IsPrimeNumber(9);
            Console.WriteLine(result);
        }
        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result = false;
                    i = number; // 6 için örnegi 6 , 3 e bölünüyor bölündügü için if e girer i = sayı olur yani 6 number-1 den büyük oldugu için ise looptan kurtulur ve gereksiz yere çalışmamış olur 
                }
            }
            return result;
        }

        private static void forLoop(string[] kurslar)
        {
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine("Kurslar : " + kurslar[i]);
            }

            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
