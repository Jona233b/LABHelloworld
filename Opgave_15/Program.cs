using System;
using System.Net.Http.Headers;



namespace Opg15
{
    class Program
    {
        static void Main(string[] args)
        {
            string afslut = "";

            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("----------------------------");
                Console.WriteLine("1. Dag og tid");
                Console.WriteLine("2. Tid til jul");
                Console.WriteLine("3. Tid til René's fødselsdag");
                Console.WriteLine("4. Tid til valgfri dato");
                Console.WriteLine("");
                Console.Write("Vælg nummer: ");
                int menu = int.Parse(Console.ReadLine());
                Console.WriteLine("");



                DateTime jul = new DateTime(DateTime.Now.Year, 12, 24, 18, 00, 00);
                DateTime nu = DateTime.Now;
                TimeSpan tidTilJul = jul - nu;



                DateTime birthday = new DateTime(DateTime.Now.Year, 12, 01);
                TimeSpan tidTilBirthday = birthday - nu;



                switch (menu)
                {
                    case 1:
                        Console.WriteLine("Dato og tid nu er " + DateTime.Now);
                        break;



                    case 2:
                        Console.WriteLine("Tid til jul: " + tidTilJul.Days + " dage, " + tidTilJul.Hours + " timer, " + tidTilJul.Minutes + " minutter, " + tidTilJul.Seconds + " sekunder.");
                        break;



                    case 3:
                        Console.WriteLine("Tid til René's fødselsdag: " + tidTilBirthday.Days + " dage, " + tidTilBirthday.Hours + " timer, " + tidTilBirthday.Minutes + " minutter, " + tidTilBirthday.Seconds + " sekunder.");
                        break;
                    case 4:
                        Console.Write("Indtast dagens nummer i måneden: ");
                        int dag = int.Parse(Console.ReadLine());
                        Console.Write("Indtast nummer for måned: ");
                        int maaned = int.Parse(Console.ReadLine());
                        Console.Write("Indtast årstal: ");
                        int aar = int.Parse(Console.ReadLine());



                        DateTime valgfri = new DateTime(aar, maaned, dag);
                        TimeSpan tidTilValgfri = valgfri - nu;



                        Console.WriteLine("");
                        Console.WriteLine("Tid til vagfri dato: " + tidTilValgfri.Days + " dage, " + tidTilValgfri.Hours + " timer, " + tidTilValgfri.Minutes + " minutter, " + tidTilValgfri.Seconds + " sekunder.");
                        break;

                    default:
                        break;
                }

                Console.WriteLine("");
                Console.Write("Tast 'x' for at afslutte programmet eller 'Enter' for at prøve igen: ");
                afslut = Console.ReadLine();
                Console.Clear();
            }
            while (afslut != "x");

            Console.WriteLine("Tryk en tast for at lukke vinduet.");
            Console.ReadKey();
        }
    }
}