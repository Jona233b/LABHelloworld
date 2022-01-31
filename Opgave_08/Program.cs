using System;

namespace Opgave_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2, b = 4;

            Console.WriteLine(a == b || a > 0);
            Console.WriteLine(a+b > 0 && a > 0);
            Console.WriteLine(a != 5 && a + b > 0);
            Console.WriteLine((true || false) && a > b);
            Console.WriteLine(3 > 5 && true || a == b);
            Console.WriteLine(b > a && true || false || b > 4);
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true);
            Console.WriteLine(true && true || false);
            Console.WriteLine(true && false && true);
            Console.WriteLine(true || false || false);
            Console.WriteLine(false && false);
            Console.WriteLine(a == 3 && b > 4 || a + 3 > b);
            Console.WriteLine(a > b && b < a && a + a == b);

        }
    }
}
