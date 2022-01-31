using System;

namespace Opgave_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("Indset det beløb du ønsker at handle for:");

            double price = double.Parse(Console.ReadLine());
            double discount = 0;

            if (price > 1000)
            {
                discount = price * 0.05;
            }
            Console.WriteLine($"Du får {discount} i rabat!");
            */

            Console.WriteLine("Indtast to tal, og jeg skal fortælle hvilket er størst.");
            Console.WriteLine("Indtast et heltal, og afslut med enter: ");

            int inputOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Indtast et heltal, og afslut med enter: ");

            int inputTwo = int.Parse(Console.ReadLine());

            if (inputOne > inputTwo)
            {
                Console.WriteLine($"Det største tal er {inputOne}");
            }
            else if (inputTwo > inputOne)
            {
                Console.WriteLine($"Det største tal er {inputTwo}");
            }
            else
            {
                Console.WriteLine($"De to tal er ens.");
            }
        }
    }
}
