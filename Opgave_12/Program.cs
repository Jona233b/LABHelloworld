using System;

namespace Opgave_12
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        
        {
            /*for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 2; i < 21; i = i + 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 7; i < 71; i = i + 7)
            {
                Console.WriteLine(i*7);
            }
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i*7);
            }

            for (int i = 1; i < 101; i++)
            {
                Console.Write( i.ToString().PadLeft(4).PadRight(4));
            }*/
            
            int Tilfældig = rand.Next(1, 7);
            Console.WriteLine(Tilfældig);

            // Opg. 12.3
            Console.WriteLine("\nKodeforslag til Jonas:");
            int tabel = 1;



            for (int j = 1; j <= 20; j++)
            {
                for (int i = tabel; i <= tabel * 20; i += j)
                {
                    Console.Write(i.ToString().PadLeft(4));
                }
                Console.WriteLine();
                tabel++;
            }
        }
    }
}
