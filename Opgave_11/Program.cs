using System;

namespace Opgave_11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int x = 1;

            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
            Console.Write("hvilken table vil du have?:");
            int table = int.Parse(Console.ReadLine());

            int x = table;

            while (x<=10*table)
            {
                Console.WriteLine(x);

                x = x + table;
            }*/
            int input = -1,tal = 0;

            while (input < 1 || input > 10)
            {
                Console.Write("Indtast et tal:");
                tal = int.Parse(Console.ReadLine());
                input = tal;
            }
            Console.WriteLine($"Dit tal er { input }");
            Console.WriteLine("Flot!");
        }
    }
}
