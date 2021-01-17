using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //type safety- tip güvenligi   alias: takma isim demektir :D 
               //do not repear yourself
               string kategoriEtiketi = "Kategori";
               int ogrenciSayisi = 32000;
               double faizOrani = 1.45;
               bool sistemeGirisYapmisMi = false;
               double dolarDun = 7.45;
               double dolarBugun = 7.45;

               if (dolarDun>dolarBugun)
               {
                   Console.WriteLine("dolar AZALDI");
               }
               else if (dolarDun<dolarBugun)
               {
                   Console.WriteLine("dolar ARTIS");
               }
               else
               {
                   Console.WriteLine("degismedi zaa");
               }




               if (sistemeGirisYapmisMi) //isTrue ? 
               {
                   Console.WriteLine("Kullanıcı ayarları butonu");
               }
               else if (true)
               {

               }
               else
               {
                   Console.WriteLine("Giris Yap butonu...");
               }
               Console.WriteLine(kategoriEtiketi);
               Console.WriteLine(kategoriEtiketi);
               Console.WriteLine(ogrenciSayisi);
               Console.WriteLine(kategoriEtiketi);

               Console.WriteLine(kategoriEtiketi);

               Console.WriteLine(kategoriEtiketi);

               */
            //double ondalikli sayilar için kullanılır
            //enum nedir? en temel amac tekrara düşmeden enum tanımlayıp daha sonradan oradan yönetmek


            double number5 = 10.4;
            decimal number6 = 10.45632432453252352356523345634563m;//sonuna m ya da M harfi koymamız gerekiyor decimal veri tipinde decimal virgülden sonra 28 29 tane deger tutar
            int number1 = -2147483648; //32 bit
            long number2 = -9223372036854775808;//int ten artık iki katı kadar yer kaplar : bellekte 19 haneden oluşur 64 bit
            short number3 = -32768;    //16 bitlik yer tutar
            byte number4 = 255;//8 bit
            Console.WriteLine("number1 is {0}", number1, number2);//{0} demek, virgülden sonraki ilk deger demektir
            Console.WriteLine("number2 is {1}", number1, number2);//{1} demek, virgülden sonraki ilk deger demektir
            Console.WriteLine("number3 is {2}", number1, number2, number3);//{2} demek, virgülden sonraki ilk deger demektir
            Console.WriteLine((int)(Days.Friday));
            //var variable degisken tutmak için kullanlılr
            var number7 = 10.4; //ne atarsak atayalım onu algılayıp ona göre tutar

            int secilenGun = (int)(Days.Wednesday);
            if (secilenGun == 1)
            {
                Console.WriteLine(secilenGun);
            }

            /* // enum örnegi
                Days secilenGun = Days.Wednesday;

                if (secilenGun == Days.Saturday || secilenGun == Days.Sunday)
                {
                    Console.WriteLine("Hafta sonu seçtiniz.");
                }
                else
                {
                    Console.WriteLine("Hafta içi seçtiniz.");
                }
            */


            //şart blokları
            var number8 = 10;
            if (number8 == 10)
            {
                Console.WriteLine("sayi 10 dur");
            }

            Console.WriteLine(number8 == 10 ? "sayı 10" : "sayı 10 degil"); //single line if


            switch (number8)
            {
                case 10:
                    Console.WriteLine("10 10 10 ");
                    break;
                default:
                    Console.WriteLine("10 degillll");
                    break;
            }


            //
            if (number8 >= 0 && number8 <= 100)
            {
                Console.WriteLine("number is between 0-100");
            }
            else if (number8 > 100 && number8 <= 200)
            {
                Console.WriteLine("100-2000");
            }
        }



        //metotlar işlem tekrarından kurtulmak için kullanılır.. static içinde kullanacaksam static tanimlariz
        static int Add(int sayi1, int sayi2)
        {
            var result = sayi1 + sayi2;
            return result;
        }

        //default parameteres method
        static int Add2(int sayi1 = 10, int sayi2 = 20) // herhangi bir sayı verilmezse sayi1=10 sayi2=20 kullan demektir 
                                                        // ayrıca unutma default degerler paramtrenin en sonda yazılır yani static int Add2(int sayi1, int sayi2=20)
        {
            var result = sayi1 + sayi2;
            return result;
        }

        //ref keyword ile çalışmak   normlade deger tip iken number1 biz onu ref keyword ile referance type yapmış olduk 
        //kısaca deger tpilerin referans tipler gibi kullanılmasını saglar
        static int Add3(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

        //out keyword ile çalışmak ref gibidir ama refte başlanıçta bir deger atamak gerekir outta gerekmez  
        static int Add4(out int number1, int number2)
        {
            number1 = 30;// outta ise metod içinde set etmek (tanımlamak ) gerekiyor
            return number1 + number2;
        }

        //method overloading examples :aşırı yüklenemsi
        static int Multiply(int number1, int number2)
        {
            var result = number1 * number2;
            return result;
        }
        static int Multiply(int number1, int number2, int number3)
        {
            var result = number1 * number2 * number3;
            return result;
        }
        //params keyword ile çalışmak 
        static int Add4(params int[] numbers) //ayni tipte kaç tane istiyorsak parametre yollayabiliriz demektir
        {
            //params parametrelierlerin son parametresi olmak zorunda mantık olarak zaten
            //static int Add4(int number1,params int[] numbers) şeklinde de yazılabilir.
            return numbers.Sum();//using System.Linq kütüphanesini kullanmalıyız bunu Sum() fonk kullannmak için

        }
    }

    enum Days
    {
        //belli bir indise göre yerleştirilir ama manuel olarak degistirebiliriz sunday =5 . indis olsun gibi 
        Monday, Tuesday, Wednesday = 1, Thursay, Friday, Saturday, Sunday
    }
}
