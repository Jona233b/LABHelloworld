using System;

namespace Opgave_10
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("kan du finde fem dyr på min liste?");
            Console.Write("skriv et dyr: ");
            string dyr = Console.ReadLine();

            switch (dyr)
            {
                case "undulat":
                    Console.WriteLine("Undulaten (Melopsittacus undulatus) er en lille papegøje, der stammer fra Australien. Arten er den eneste i slægten Melopsittacus." +
                        "Der findes den lille australske undulat (den man finder i naturen), og den store engelske undulat, som er opdrættet mhp." +
                        "udstilling. Den australske bliver ca 18 cm lang, har indtrukket næb og udstående øjne, og vejer 30 - 40 g som unger og 40 - 50 g som voksne." +
                        "Den engelske undulat bliver samme længde, men vejer omkring 50 - 75 g.de har meget større fjerdragt, og ikke de udstående øjne."); //fra Wikipedia*
                    break;
                case "papegøje":
                    Console.WriteLine("Papegøjer varierer meget i størrelse, fra de mindste spættepapegøjer, der blot måler omkring otte centimeter, til de største araer og grønne amazoner, der, med halefjer, har en længde på op mod en meter." +
                        "Den største blandt araerne, hyasintara, Anodorhynchus hyacinthinus, har et vingefang på 120 - 140 centimeter." +
                        "Karakteristisk for alle papegøjer er det kraftige næb, hvor overnæbbet krummer ned over det kortere undernæb." +
                        "De fleste papegøjer har farvestrålende fjerdragt.Deres stemmer er kraftige, skrattende og umelodiske.Enkelte arter er i stand til at efterligne mennesketale."); //fra Wikipedia*
                    break;
                case "hund":
                    Console.WriteLine("Tamhunden (Canis lupus familiaris) er det husdyr, som tidligst blev tæmmet af mennesket, og som derfor har den længste historie til fælles med os." +
                        "Den har gennem historien været brugt til jagt, som vagthund, krigshund (eks. anti-tank-hunde), sporhund, redningshund, eller som følgesvend." +
                        "Desuden som servicehund for blinde og handicappede, som politi- og redningshund, som narkohund eller som terapihund." +
                        "Hunde kan også lugte sig frem til kræftsvulster, termitangreb og forudsige epilepsianfald.");//fra Wikipedia*
                    break;
                case "kat":
                    Console.WriteLine("Tamkatten (Felis catus eller Felis silvestris catus) er et lille, tæmmet, kødædende pattedyr oftest med pels." +
                        "Den kaldes huskat eller bare kat, når der ikke er grund til at skelne den fra andre kattedyr." +
                        "Katten er værdsat af mennesker for dens selskab og evne til at jage mus og rotter. Mange huskatte bliver op mod 20 år gamle." +
                        "Kattens anatomi ligner andre kattedyr: stærke, fleksible kroppe, hurtige reflekser, skarpe klør og tænder, der er velegnede til at dræbe byttet." +
                        "Katte bruger deres gode hørelse og evnen til at se i næsten totalt mørke til at jage i tusmørke." +
                        "Katte kan høre lyde, der er både dybere og højere end hvad mennesker kan høre.Det skyldes, at kattes hørelse er tilpasset deres naturlige bytte, der ofte er gnavere som mus.Når katte kommunikerer, bruger de miaven, spinden, hvæsen, dufte og kropssprog." +
                        "Katte kan formere sig hurtigt.Undladelse af kastration og sterilisation og senere efterladelse af dem har resulteret i henved 60 millioner vildtlevende katte i Nordamerika alene." +
                        "Under kontrollerede forhold avles katte og får registrerede stamtavler, såkaldte racekatte.Fordi katte var tilbedte og højt værdsatte i oldtidens Ægypten, antoges det, at dyret blev domesticeret der, men der kan have været tilfælde af domesticering så tidligt som i stenalderen." +
                        "Et genetisk studie i 2007 viste, at alle huskatte nedstammer fra fem hundyr af den afrikanske vildkat(Felis silvestris lybica) ca. 8000 f.Kr.i Mellemøsten. Katten er i øjeblikket det mest populære kæledyr og kan findes næsten overalt i verden.");//fra Wikipedia*
                    break;
                case "gris":
                    Console.WriteLine("Tamsvin eller svin er betegnelsen for den gruppe af svinefamilien, der opdrættes til slagtning. Det nedstammer fra vildsvinet. Biologisk er svin en gruppe af enkeltmavede og altædende, parrettåede hovdyr.");//fra Wikipedia*
                    break;
                default:
                    Console.WriteLine("Fejl dyr ikke på listen");
                    break;
            }


        }
    }
}
