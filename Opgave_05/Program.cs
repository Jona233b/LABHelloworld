using System;

namespace Opgave_05
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal1 = 0;
            double tal2 = 0;

            Console.WriteLine("Console Calculator Med C#");

            Console.WriteLine("Indtast et tal, og tryk på Enter");
            tal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Indtast et andet nummer, og tryk på Enter");
            tal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Vælg en mulighed fra følgende liste:");
            Console.WriteLine("\t1 - Plus");
            Console.WriteLine("\t2 - Minus");
            Console.WriteLine("\t3 - Gange");
            Console.WriteLine("\t4 - Divider");
            Console.Write("Din mulighed?: ");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Dit resultat: {tal1} + {tal2} = " + (tal1 + tal2));
                    break;
                case "2":
                    Console.WriteLine($"Dit resultat: {tal1} - {tal2} = " + (tal1 - tal2));
                    break;
                case "3":
                    Console.WriteLine($"Dit resultat: {tal1} * {tal2} = " + (tal1 * tal2));
                    break;
                case "4":
                    Console.WriteLine($"Dit resultat: {tal1} / {tal2} = " + (tal1 / tal2));
                    break;
            }

            Console.Write("Tryk på en vilkårlig tast for at lukke Appen...");
            Console.ReadKey();

        }
    }
}
