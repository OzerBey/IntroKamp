using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /* overload a kadar olan yerlerin maini
             * Console.WriteLine(Add(5, 3));
             var resultDefault = Add2();
             var result = Add2(15, 23);
             Console.WriteLine(result);
             Console.WriteLine("------ref denenme-----");
             int number1 = 20;
             int number2 = 100;
             var resultAdd3 = Add3(ref number1, number2);
             Console.WriteLine(resultAdd3);
             Console.WriteLine("number1 is :{0}", number1); // 20 yazar
            */

            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply(2, 4, 5));
            Console.WriteLine("sayilarin toplami :{0}",Add4(1,2,3,4,5,6,7,8,9,10));
        }

    }
}
