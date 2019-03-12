using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            CVehicle car = new CCar("Ferrari 458", 1, 1, 100000, 100, 2009);
            CVehicle car1 = new CCar("Ferrari f40", 2, 2, 50000, 150, 1992);

            CVehicle plane = new CPlane("Boing 737", 1, 1, 100000, 100, 1989, 10000, 130);
            CVehicle plane1 = new CPlane("AN-158", 1, 1, 100000, 800, 2010, 10000, 86);

            CVehicle ship = new CShip("Titanic", 1, 1, 300000, 15, 1912, "New York City", 2208);
            CVehicle ship1 = new CShip("Aphrodite", 1, 1, 20000, 20, 2011, "Kiev", 200);
            //CVehicle ship1 = new CShip { Name = "Titanic",  x = 1, y = 1, price = 100000, speed = 100, yearIssue = 1912, port ="New York City", countPass =2208);

            CVehicle[] vehicle = new CVehicle[6] { car, car1, plane, plane1, ship, ship1 };
            foreach (CVehicle item in vehicle)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
