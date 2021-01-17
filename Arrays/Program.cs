using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string student1 = "Yasin";
            string student2 = "Özer";
            string student3 = "Ali";
            string student4 = "Engin";

            //string array example
            string[] students = new string[] { student1, student2, student3, student4,"Osman"}; //tek boyutlu bir string dizisi
            foreach (var std in students)
            {
                //Console.WriteLine(std);
            }
            
            //cok boyutlu diziler
            string[,] regions = new string[5, 3] //5 bölge 3 şehir için iki boyutlu dizi --yani 5 satır 3 sütun
            { 
            {"İstanbul","İzmit","Balikesir"},
            {"Ankara","Konya","Kırıkkale"},
            {"Antalya","Adana","Mersin"},
            {"Rize","Trabzon","Samsun"},
            {"İzmir","Muğla","Manisa"},
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)// regions.GetUpperBound(0) regions daki 0. dimension ın en üst degeri demek
                for (int j = 0; j <= regions.GetLowerBound(1); j++)// regions.GetLowerBound(0) regions daki 1. dimension ın en alt degeri demek
                {
                    Console.WriteLine(regions[i,j]);
                    /*
                     output:
                    İstanbul
                    Ankara
                    Antalya
                    Rize
                    İzmir
                     */
                }
             }
        }
    }

