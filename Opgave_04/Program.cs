using System;

namespace Opgave_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast fornavn.");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Indtast efternavn.");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Dit navn er");
            Console.Write(userInput1);
            Console.Write(" "); //så man få et mellenmrum
            Console.Write(userInput2);
            Console.WriteLine($" Velkommen { userInput1} { userInput2}!");

        }
    }
}
