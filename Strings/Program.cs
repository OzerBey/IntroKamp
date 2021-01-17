using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentece = "My name is Yasin Özer";
            var result = sentece.Length;
            var result2 = sentece.Clone();
            //sentece = "My name is aLi";
            bool result3 = sentece.EndsWith("r");
            bool result4 = sentece.StartsWith("My name");
            var result5 = sentece.IndexOf("name");
            var result6 = sentece.LastIndexOf(" ");
            var result7 = sentece.Insert(0, "Hello! ");
            var result8 = sentece.Substring(3); // 3. karakterden itibaren alır
            var result9 = sentece.ToLower();
            var result10 = sentece.ToUpper();
            var result11 = sentece.Replace(" ", "_"); // ilk kısım yerine ikinci olani yerleştirir yani boşluk yerine _ koyar
            var result12 = sentece.Remove(2, 5); // 2 den itibaren 5 karakteri kaldırır
            var result13 = sentece.Contains("a");// a içeriyor mu boolean deger döndürür
            var result14 = sentece.Trim(); // boşlukları ortadan kaldırır
            var result15 = sentece.GetTypeCode();//code type döndürür ne oldugunu string bu mesela
            Console.WriteLine(result15);
            Console.WriteLine(sentece);

        }

        private static void Intro()
        {
            string city = "Ankara";
            Console.WriteLine(city);

            foreach (char item in city)
            {
                Console.WriteLine(item); // string aynı zamanda bir char array i oldugu için karakter karakter yazar çıktı olarak
            }

            string city2 = "İstanbul"; // string toplama
            string result = city + city2;
            Console.WriteLine(result);
            var deneme = String.Format("{0} {1}", city, city2); // yeni degerle ile hafızayı mesgul etmek yerıne bazı buna bnzer yapılar kullanılabilir 
                                                                // format sınıfını kullanarak
            Console.WriteLine(deneme);
            //veya diger bi yöntem
            Console.WriteLine("{0} : {1}", city, city2);

            //string metodalrı ile çalışmak
        }
    }
}
