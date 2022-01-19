using System;

namespace Opgave02
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Karstes";
            string lastName = "Hansen";
            int age = 35;

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(age);

            Console.WriteLine($"Fornavn: {firstName}. Efternavn: {lastName}. Alder.");

            string tittel = "Lord of the The Rings - The Two Towers";
            long isbn = 9780007117116;
            int pages = 450;
            double price = 249.95;

            Console.WriteLine(tittel);
            Console.WriteLine(isbn);
            Console.WriteLine(pages);
            Console.WriteLine(price);

            int maxInt = int.MaxValue;
            int minInt = int.MinValue;

            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);
            //blablabla


        }
    }
}
