using System;

namespace Opgave_10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("skriv en karakter: ");
            string karakter = Console.ReadLine();

            switch (karakter)
            {
                case "-03":
                    Console.WriteLine("-03:For den ringe præstation. Karakteren -3 gives for den helt uacceptable præstation.");
                    break;
                case "00":
                    Console.WriteLine("00:For den utilstrækkelige præstation. Karakteren 00 gives for den utilstrækkelige præstation, der ikke demonstrerer en acceptabel grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case "02":
                    Console.WriteLine("02:For den tilstrækkelige præstation. Karakteren 02 gives for den tilstrækkelige præstation, der demonstrerer den minimalt acceptable grad af opfyldelse af fagets/fagelementets mål.");
                    break;
                case "04":
                    Console.WriteLine("04:For den jævne præstation. Karakteren 4 gives for den jævne præstation, der demonstrerer en mindre grad af opfyldelse af fagets/fagelementets mål, med adskillige væsentlige mangler.");
                    break;
                case "07":
                    Console.WriteLine("07:For den gode præstation. Karakteren 7 gives for den gode præstation, der demonstrerer opfyldelse af fagets/fagelementets mål, med en del mangler.");
                    break;
                case "10":
                    Console.WriteLine("10:For den fortrinlige præstation. Karakteren 10 gives for den fortrinlige præstation, der demonstrerer omfattende opfyldelse af fagets/fagelementets mål, med nogle mindre væsentlige mangler.");
                    break;
                case "12":
                    Console.WriteLine("12:For den fremragende præstation. Karakteren 12 gives for den fremragende præstation, der demonstrerer udtømmende opfyldelse af fagets/fagelementets mål, med ingen eller få uvæsentlige mangler.");
                    break;
                default:
                    Console.WriteLine("Fejl");
                    break;
            }
        }
    }
}
