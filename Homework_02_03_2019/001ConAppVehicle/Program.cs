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
            CVehicle car = new CCar("Ferrari 458", 1, 1, 100000, 100, SpeedMeasurement.Km, 2009);
            CVehicle car1 = new CCar("Ferrari f40", 2, 2, 50000, 150, SpeedMeasurement.Km, 1992);

            CVehicle plane = new CPlane("Boing 737", 3, 3, 100000, 900, SpeedMeasurement.Km, 1989, 10000, 130);
            CVehicle plane1 = new CPlane("AN-158", 4, 4, 100000, 800, SpeedMeasurement.Km, 2010, 10000, 86);

            CVehicle ship = new CShip("Titanic", 5, 5, 300000, 1500, SpeedMeasurement.Mile, 1912, "New York City", 2208);
            CVehicle ship1 = new CShip("Aphrodite", 6, 6, 20000, 20, SpeedMeasurement.Mile, 2009, "Kiev", 200);
            //CVehicle ship1 = new CShip { Name = "Titanic",  x = 1, y = 1, price = 100000, speed = 100, yearIssue = 1912, port ="New York City", countPass =2208);

            //виведемо всі транспортні засоби на екран
            CVehicle[] vehicle = new CVehicle[6] { car, car1, plane, plane1, ship, ship1 };
            foreach (CVehicle item in vehicle)
            {
                Console.WriteLine(item.ToString());
            }

            //знайдемо набільшу ціну
            CVehicleAnalysis.GetMaxPrice(vehicle);
            //знайдемо найшвидший транспортний засіб
            CVehicleAnalysis.GetMaxSpeed(vehicle);
            // Найти транспортні засоби заданого року
            CVehicleAnalysis.FindVehicleGivenYear(vehicle, 2009);

            Console.ReadKey();
        }
    }
}
