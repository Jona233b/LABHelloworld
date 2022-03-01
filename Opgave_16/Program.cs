using System;

namespace Opgave_16
{
    class Program
    {
        private static void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        private static void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye " + name);
        }
        static void Main(string[] args)
        {
            SayHello("Daniel");
            SayGoodbye("Karsten");
        }
    }
}
