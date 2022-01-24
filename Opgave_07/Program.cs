using System;

namespace Opgave_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indset det beløb du ønsker at handle for:");

            double price = double.Parse(Console.ReadLine());
            double discount = 0;

            if (price > 1000)
            {
                discount = price * 0.05;
            }
            Console.WriteLine($"Du får {discount} i rabat!");
        }
    }
}
