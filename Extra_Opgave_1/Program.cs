using System;

namespace Extra_Opgave_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int input = 0;

            while (i < 5)
            {
                Console.Write("Intast et tal: ");
                int tal = Convert.ToInt32(Console.ReadLine());
                input = input + tal;
                i++;
            }
            Console.WriteLine($"Resultatet af tallene {input}");
        }   
    }
}
