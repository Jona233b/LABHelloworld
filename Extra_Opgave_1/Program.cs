using System;

namespace Extra_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.Write("While statment: ");
                Console.WriteLine(i);
                i++;

                if (i == 10)
                {
                    Console.WriteLine("Denne løkke har kørt 10 gange.");
                }
            }
        }
    }
}
