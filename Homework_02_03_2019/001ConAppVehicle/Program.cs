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
            CProgramSettings.PrintVersionProg(); //Виведемо версію програми

            CVehicle car1 = new CCar("Ferrari 458", 1, 1, 100000, 100, SpeedMeasurement.km, 2005);
            CVehicle car2 = new CCar("Ferrari f40", 2, 2, 50000, 151, SpeedMeasurement.km, 2004);
            CVehicle car3 = new CCar("BMW M5", 2, 2, 45000, 230, SpeedMeasurement.km, 2018);

            var bm1 = new CBatmobile(car1);
            bm1.Move();
            Console.WriteLine($"После модернизации {bm1.Name} в бэтмобиль, мы назвали его BatRarri 458X!");
            bm1.Name = "BatRarri 458X";
            
            bm1.Move();




            CVehicle plane1 = new CPlane("Boing 737", 3, 3, 100000, 900, SpeedMeasurement.km, 2015, 10000, 130);
            CVehicle plane2 = new CPlane("AN-158", 4, 4, 100000, 800, SpeedMeasurement.km, 2001, 10000, 86);

            CVehicle ship1 = new CShip("Titanic", 5, 5, 300000, 60, SpeedMeasurement.m, 1912, "New York City", 2208);
            CVehicle ship2 = new CShip("Aphrodite", 6, 6, 10000, 40, SpeedMeasurement.m, 2015, "Kiev", 200);
            CVehicle ship3 = new CShip("Lincoln", 6, 6, 5000, 40, SpeedMeasurement.m, 2019, "Kiev", 200);
            CVehicle ship4 = new CShip("Aphrodit", 6, 6, 20000, 40, SpeedMeasurement.m, 2016, "Kiev", 200);

            //виведемо всі транспортні засоби на екран
            CVehicle[] vehicle = new CVehicle[] { car1, car2, car3, plane1, plane2, ship1, ship2, ship3, ship4 };
            CVehicleAnalysis.PrintVehicleArr(vehicle);

            //розділимо вивід на екран
            Console.WriteLine();

            //знайдемо найдорожчий транспортний засіб
            CVehicleAnalysis.GetMaxPrice(vehicle);
            //знайдемо найшвидший транспортний засіб
            CVehicleAnalysis.GetMaxSpeed(vehicle);
            // Найти транспортні засоби заданого року
            CVehicleAnalysis.FindVehicleGivenYear(vehicle, 2009);
            Console.WriteLine();
            //Виводимо інформацію по кількості пасажирів
            CVehicleAnalysis.PrintPassenger(vehicle);

            Console.WriteLine(new string('=', 50));
            //Vehicle с наибольшей ценой
            CVehicleAnalysis.Method0(vehicle);

            Console.WriteLine(new string('=', 50));
            //Механизм год выпуска 2000 - 2005 с скоростью выше 150 км\ч, и наименьшей ценой
            CVehicleAnalysis.Method1(vehicle);

            Console.WriteLine(new string('=', 50));
            //Из Масива Vehicle получить масив Car не старше 5 лет
            CVehicleAnalysis.Method2(vehicle);

            Console.WriteLine(new string('=', 50));
            //Из Масива Vehicle получить масив Ship не старше 5 лет, с отсортированой ценой по убыванию
            CVehicleAnalysis.Method3(vehicle);

            Console.WriteLine(new string('=', 50));
            //Создать 3 последовательности IFly, ISwim, IMove
            IFly[] masFly = { car1 as IFly, plane1 as IFly, ship1 as IFly, new CBatmobile((CCar)car1) as IFly };
            ISwim[] masSwim = { car1 as ISwim, plane1 as ISwim, ship1 as ISwim, new CBatmobile((CCar)car1) as ISwim, new CAmphibian((CCar)car1) as ISwim };
            IMove[] masMove = { car1 as IMove, plane1 as IMove, ship1 as IMove, new CBatmobile((CCar)car1) as IMove, new CAmphibian((CShip)ship1) as IMove };

            masMove[3].Move();


            Console.WriteLine("\n masFly:");
            foreach (var item in masFly)
            {
                if ((object)item != null)
                {
                    item.Fly();
                }
            }
            Console.WriteLine("\n masSwim:");
            Array.Sort(vehicle, new CompareByPrice());
            foreach (var item in masSwim)
            {
                if ((object)item != null)
                {
                    item.Swim();
                }
            }
            Console.WriteLine("\n masMove:");
            foreach (var item in masMove)
            {
                if ((object)item != null)
                {
                    item.Move();
                }
            }

            IFly[] masFly1;
            CVehicleAnalysis.GetIFlyFromArrVeh(vehicle, out masFly1);

            var flyObjects = CVehicleAnalysis.getSpecialVehicle<IFly>(vehicle).Select(x => x as IFly).ToArray();
            var swimObjects = CVehicleAnalysis.getSpecialVehicle<ISwim>(vehicle).Select(x => x as ISwim).ToArray();
            var moveObjects = CVehicleAnalysis.getSpecialVehicle<IMove>(vehicle).Select(x => x as IMove).ToArray();

            Console.ReadKey();
        }
    }
}
