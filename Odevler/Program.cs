using System;

namespace Odevler
{
    class Program
    {
        public static void Main(string[]args)
        {
            /*
             * 
             * 
            Product product1 = new Product();
            product1.urunAdi = "Saat";
            product1.urunFiyati = 500;
            product1.urunSaticisi = "Rolex";


            Product product2 = new Product();
            product2.urunAdi = "Telefon";
            product2.urunFiyati = 1649;
            product2.urunSaticisi = "General Mobile";


            Product product3 = new Product();
            product3.urunAdi = "Ceket";
            product3.urunFiyati = 350;
            product3.urunSaticisi = "Ghassy";


            Product product4 = new Product();
            product4.urunAdi = "Tablet";
            product4.urunFiyati = 1500;
            product4.urunSaticisi = "Ghassy";


            Product product5 = new Product();
            product5.urunAdi = "Koltuk";
            product5.urunFiyati = 2000;
            product5.urunSaticisi = "Sofabille";


            Product product6 = new Product();
            product6.urunAdi = "Bisiklet";
            product6.urunFiyati = 350;
            product6.urunSaticisi = "Bisansa";


            Product product7 = new Product();
            product7.urunAdi = "Kitaplık";
            product7.urunFiyati = 380;
            product7.urunSaticisi = "İkea";


            Product product8 = new Product();
            product8.urunAdi = "Masa";
            product8.urunFiyati = 485;
            product8.urunSaticisi = "Bauhaus";

            //Product arrays
            Product[] products = new Product[] { product1, product2, product3, product4, product5, product6, product7, product8 };

            //with for loop
            Console.WriteLine("For--------------");
            for (int i = 0; i < products.Length; i++)
                {
                Console.WriteLine(products[i].urunAdi + " " + products[i].urunFiyati + "₺ " + products[i].urunSaticisi);
             }

            //with foreach loop
            Console.WriteLine("Foreach-------------------");
            foreach (Product prdct in products)
                {
                Console.WriteLine(prdct.urunAdi + " " + prdct.urunFiyati + "₺ " + prdct.urunSaticisi);
                }
             //with while loop
             Console.WriteLine("while----------------");
             int c = 0;
                while (c < products.Length)
                {
                Console.WriteLine(products[c].urunAdi + " " + products[c].urunFiyati + "₺ " + products[c].urunSaticisi);
                c++;
                }*/


            //Kullanıcının girdiği 5 sayıdan 50′ den büyük olanların toplamını 
            //gösteren programı kodlayınız.

            int sayi;
            int i=0,sum=0;
             while (i<5)
             {
                 Console.WriteLine("Enter a number");
                 sayi = Convert.ToInt32(Console.ReadLine());
                 Console.WriteLine("girilen sayi: "+sayi);
                 if (sayi>50)
                 {
                     sum += sayi;
                 }
                 i++;
                }
                Console.WriteLine("50 den büyük olanların toplamı "+sum);
            }
        }
    }



class Product
{
    public string urunAdi { get; set; }
    public int urunFiyati { get; set; }
    public string urunSaticisi { get; set; }
}

