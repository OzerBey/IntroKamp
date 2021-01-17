using System;

namespace Method
{
    class Program
    {

        static void Main(string[] args)
        {
            //Instance
            Product product1 = new Product();
            product1.ProductName = "Apple";
            product1.UnitPrice = 10.5;
            product1.Description = "Amasya";

            Product product2 = new Product();
            product2.ProductName = "Watermelon";
            product2.UnitPrice = 81;
            product2.Description = "Diyarbakır";

            Product product3 = new Product();
            product3.ProductName = "Orange";
            product3.UnitPrice = 14;
            product3.Description = "Ege";

            Product[] products = new Product[] { product1, product2 };

            //type safe 
            foreach (Product product in products)
            {
                Console.WriteLine("Product :" + product.ProductName + " Price :" + product.UnitPrice + " $  Description :" + product.Description);
            }


            Console.WriteLine("------------------Methods---------------------");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);



        }
    }
}

//Don't Repeat Yourself- DRY prensibine istinaden metotlar aynı yerlerde aynı kodu bir dha yazmamak için tek fonkisyon yazıp farklı yerlerde kullanabilmeyi saglar 
