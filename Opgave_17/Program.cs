using System;

namespace Opgave_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            cars car1 = new cars("Ford", "Mustang", 1966, "Rød" );
            cars car2 = new cars("Porsche", "911", 2004, "Sølv" );

            cars.Add( car1 );
            cars.Add( car2 );

            Console.WriteLine("Informationer om bilerne:");
            foreach ( Car c in cars)
            {
                Console.WriteLine(c.GetInfo());
            }
        }
    }
}
