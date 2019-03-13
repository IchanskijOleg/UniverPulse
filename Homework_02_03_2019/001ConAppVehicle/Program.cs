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
            CVehicle car1 = new CCar("Ferrari 458", 1, 1, 100000, 100, SpeedMeasurement.km, 2009);
            CVehicle car2 = new CCar("Ferrari f40", 2, 2, 50000, 150, SpeedMeasurement.km, 1992);

            CVehicle plane1 = new CPlane("Boing 737", 3, 3, 100000, 900, SpeedMeasurement.km, 1989, 10000, 130);
            CVehicle plane2 = new CPlane("AN-158", 4, 4, 100000, 800, SpeedMeasurement.km, 2010, 10000, 86);

            CVehicle ship1 = new CShip("Titanic", 5, 5, 300000, 60, SpeedMeasurement.m, 1912, "New York City", 2208);
            CVehicle ship2 = new CShip("Aphrodite", 6, 6, 20000, 40, SpeedMeasurement.m, 2009, "Kiev", 200);

            //виведемо всі транспортні засоби на екран
            CVehicle[] vehicle = new CVehicle[6] { car1, car2, plane1, plane2, ship1, ship2 };
            foreach (CVehicle item in vehicle)
            {
                Console.WriteLine(item.ToString());
            }

            //розділимо вивід на екран
            Console.WriteLine();
            //знайдемо найдорожчий транспортний засіб
            CVehicleAnalysis.GetMaxPrice(vehicle);
            //знайдемо найшвидший транспортний засіб
            CVehicleAnalysis.GetMaxSpeed(vehicle);
            // Найти транспортні засоби заданого року
            CVehicleAnalysis.FindVehicleGivenYear(vehicle, 2009);

            Console.ReadKey();
        }
    }
}
