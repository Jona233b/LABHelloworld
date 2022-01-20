using System;

namespace Opgave_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int tal1 = 0;
            int tal2 = 0;



            Console.WriteLine("Velkommen til lommeregneren version 1.");
            Console.WriteLine("Jeg er en simpel lommeregner, som udelukkende kan lægge to tel sammen.");
            Console.WriteLine("Intast et tal");

            tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Intast et nyt tal");

            tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Resultat {tal1 + tal2}");

        }
    }
}
