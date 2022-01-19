using System;

namespace LABHelloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string schoolName;
                schoolName = "AspIT";

                Console.WriteLine(schoolName);

                schoolName = "AspIT - Nordjylland";

                Console.WriteLine(schoolName);

                string motto = "Fokuseret Talent";

                Console.Write( schoolName );
                Console.Write("");
                Console.WriteLine(motto);
                Console.WriteLine($"{schoolName}{motto}");



            }
        }
    }
}
