using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CVehicleAnalysis
    {
        /// <summary>
        /// Найбільна ціна серед транспортних засобів
        /// </summary>
        /// <param name="vehicle">Масив транспортних засібів</param>
        public static void GetMaxPrice(CVehicle[] vehicle)
        {
            CVehicle res = vehicle[0];
            foreach (CVehicle item in vehicle)
            {
                if (item.Price > res.Price)
                {
                    res = item;
                }
            }
            Console.WriteLine("Найбільша ціна складає {0} дол.США за \"{1}\".", res.Price, res.Name);
        }

        /// <summary>
        /// Мінімальна ціна ТЗ
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        /// <returns>ТЗ з мінімальною ціною</returns>
        public static CVehicle GetVehicleMinPrice(CVehicle[] arrVehicle)
        {
            if (arrVehicle.Length == 0)
            {
                return null;
            }
            else
            {
                Array.Sort(arrVehicle, new CompareByPrice());
                return arrVehicle[0];
            }
        }

        /// <summary>
        /// Максимальна ціна ТЗ
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        /// <returns>ТЗ з максимальною ціною</returns>
        public static CVehicle GetVehicleMaxPrice(CVehicle[] arrVehicle)
        {
            if (arrVehicle.Length == 0)
            {
                return null;
            }
            else
            {
                Array.Sort(arrVehicle, new CompareByPrice());
                return arrVehicle[arrVehicle.Length - 1];
            }
        }

        /// <summary>
        /// Найбільша швидкість серед транспортних засобів
        /// </summary>
        /// <param name="vehicle">Масив транспортних засібів</param>
        public static void GetMaxSpeed(CVehicle[] vehicle)
        {
            CVehicle res = vehicle[0];
            foreach (CVehicle item in vehicle)
            {
                //приведемо все до кілометрів і порівняємо швидкості
                if (CConvertor.SpeedConvert(item.SpeedMeasure, item.Speed, SpeedMeasurement.km) >
                    CConvertor.SpeedConvert(res.SpeedMeasure, res.Speed, SpeedMeasurement.km))
                {
                    res = item;
                }
            }
            Console.WriteLine("Найбільша швидкість в \"{2}\" яка дорівнює {0}{1}/h.", res.Speed, res.SpeedMeasure, res.Name);
        }

        /// <summary>
        /// Найти транспортні засоби заданого року
        /// </summary>
        /// <param name="vehicle">Масив транспортних засібів</param>
        public static void FindVehicleGivenYear(CVehicle[] vehicle, int year)
        {
            foreach (CVehicle item in vehicle)
            {
                if (item.YearIssue == year)
                {
                    Console.WriteLine("Транспортний засіб \"{0}\" {1} року виробництва.", item.Name, item.YearIssue);
                }
            }
        }

        /// <summary>
        /// Виводимо інформацію по кількості пасажирів
        /// </summary>
        /// <param name="vehicle">Масив транспортних засібів</param>
        public static void PrintPassenger(CVehicle[] vehicle)
        {
            foreach (CVehicle item in vehicle)
            {
                if (item is IPassenger)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        /// <summary>
        /// Из Масива Vehicle получить масив Car  
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        /// <param name="arrCar">Масив автомобілів</param>
        public static void GetCarFromVehicle(CVehicle[] arrVehicle, out CCar[] arrCar)
        {
            CVehicle[] masVehicle = new CVehicle[arrVehicle.Length];
            int count = 0;
            foreach (var item in arrVehicle)
            {
                if (item is CCar)
                {
                    masVehicle[count] = item as CCar;
                    count++;
                }
            }
            CCar[] masCar = new CCar[count];
            Array.Copy(masVehicle, masCar, count);
            arrCar = masCar;
        }

        /// <summary>
        /// Из Масива Vehicle получить масив Ship  
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        /// <param name="arrShip">Масив кораблів</param>
        public static void GetShipFromVehicle(CVehicle[] arrVehicle, out CShip[] arrShip)
        {
            CVehicle[] masVehicle = new CVehicle[arrVehicle.Length];
            int count = 0;
            foreach (var item in arrVehicle)
            {
                if (item is CShip)
                {
                    masVehicle[count] = item as CShip;
                    count++;
                }
            }
            CShip[] masCShip = new CShip[count];
            Array.Copy(masVehicle, masCShip, count);
            arrShip = masCShip;
        }

        /// <summary>
        /// Виводимо на екран інформацію по транспортному засобу
        /// </summary>
        /// <param name="vehicle"></param>
        public static void PrintVehicle(CVehicle vehicle)
        {
            if (vehicle != null)
            {
                Console.WriteLine(vehicle.ToString());
            }
        }

        /// <summary>
        /// Виводимо на екран інформацію по транспортних засобах
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        public static void PrintVehicleArr(CVehicle[] arrVehicle)
        {
            foreach (var item in arrVehicle)
            {
                PrintVehicle(item);
            }
        }

        /// <summary>
        /// Транспортний засіб в яких рік випуску в межах
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        /// <param name="yearFrom">Рік з</param>
        /// <param name="yearTill">Рік по</param>
        public static void FindVehicleBetweenYear(ref CVehicle[] arrVehicle, int yearFrom, int yearTill)
        {
            CVehicle[] masVehicle = new CVehicle[arrVehicle.Length];
            int count = 0;
            foreach (var item in arrVehicle)
            {
                if (yearFrom <= item.YearIssue && item.YearIssue <= yearTill)
                {
                    masVehicle[count] = item;
                    count++;
                }
            }
            CVehicle[] newVehicle = new CVehicle[count];
            Array.Copy(masVehicle, newVehicle, count);
            arrVehicle = newVehicle;
        }

        /// <summary>
        /// ТЗ з швидкістю більше ніж задана
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        /// <param name="speed">Швидкість</param>
        public static void FindVehicleGivenSpeed(ref CVehicle[] arrVehicle, int speed)
        {
            CVehicle[] masVehicle = new CVehicle[arrVehicle.Length];
            int count = 0;
            foreach (var item in arrVehicle)
            {
                if (item.Speed > speed)
                {
                    masVehicle[count] = item;
                    count++;
                }
            }
            CVehicle[] newVehicle = new CVehicle[count];
            Array.Copy(masVehicle, newVehicle, count);
            arrVehicle = newVehicle;
        }

        /// <summary>
        /// Vehicle с наибольшей ценой
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        public static void Method0(CVehicle[] arrVehicle)
        {
            Console.WriteLine("Vehicle с наибольшей ценой");

            CVehicle v = GetVehicleMaxPrice(arrVehicle);
            if (v != null)
            {
                PrintVehicle(v);
            }
            else
            {
                Console.WriteLine("ТЗ з заданими умовами немає");
            }
        }

        /// <summary>
        /// Механизм год выпуска 2000 - 2005 с скоростью выше 150 км.ч, и наименьшей ценой
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        public static void Method1(CVehicle[] arrVehicle)
        {
            Console.WriteLine("Механизм год выпуска 2000 - 2005 с скоростью выше 150 км.ч, и наименьшей ценой");

            Console.WriteLine("масив ТЗ які лежать в межах років 2000 - 2005:");
            FindVehicleBetweenYear(ref arrVehicle, 2000, 2005);
            PrintVehicleArr(arrVehicle);

            Console.WriteLine("масив ТЗ в яких швидкість більше 150:");
            FindVehicleGivenSpeed(ref arrVehicle, 150);
            PrintVehicleArr(arrVehicle);

            Console.WriteLine("знаходимо ТЗ з мінімальною ціною:");
            CVehicle v = GetVehicleMinPrice(arrVehicle);
            if (v != null)
            {
                PrintVehicle(v);
            }
            else
            {
                Console.WriteLine("ТЗ з заданими умовами немає");
            }
        }

        /// <summary>
        /// Из Масива Vehicle получить масив Car не старше 5 лет
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        public static void Method2(CVehicle[] arrVehicle)
        {
            Console.WriteLine("Из Масива Vehicle получить масив Car не старше 5 лет");

            DateTime todaysDate = DateTime.Now.Date;
            int year = todaysDate.Year;
            CCar[] masCar;

            Console.WriteLine("масив ТЗ");
            PrintVehicleArr(arrVehicle);

            Console.WriteLine("ТЗ які не старше 5 років");
            FindVehicleBetweenYear(ref arrVehicle, year - 5, year);
            PrintVehicleArr(arrVehicle);

            //з ТЗ візьмемо тільки автомобілі
            GetCarFromVehicle(arrVehicle, out masCar);
            Console.WriteLine("масив автомобілів");
            PrintVehicleArr(masCar);
        }

        /// <summary>
        /// Из Масива Vehicle получить масив Ship не старше 5 лет, с отсортированой ценой по убыванию
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        public static void Method3(CVehicle[] arrVehicle)
        {
            Console.WriteLine("Из Масива Vehicle получить масив Ship не старше 5 лет, с отсортированой ценой по убыванию");

            DateTime todaysDate = DateTime.Now.Date;
            int year = todaysDate.Year;
            CShip[] masShip;

            Console.WriteLine("масив ТЗ");
            PrintVehicleArr(arrVehicle);

            Console.WriteLine("ТЗ які не старше 5 років");
            FindVehicleBetweenYear(ref arrVehicle, year - 5, year);
            PrintVehicleArr(arrVehicle);

            //з ТЗ візьмемо тільки кораблі
            GetShipFromVehicle(arrVehicle, out masShip);
            Console.WriteLine("масив кораблів відсортований по ціні по зменшенню");
            Array.Sort(masShip, new CompareByPrice());
            //робимо ціну по зменшенню - бо по замовчуванню по збільшуванню
            Array.Reverse(masShip);
            PrintVehicleArr(masShip);
        }

        public static void GetIFlyFromArrVeh(CVehicle[] arrVehicle, out IMove[] arrProcess)
        {
            IMove[] masMove = new IMove[arrVehicle.Length];
            int i = 0;
            foreach (var item in arrVehicle)
            {
                if (item is IMove)
                {
                    masMove[i++] = item as IMove;
                }
            }
            Array.Resize(ref masMove, i);
            arrProcess = masMove;
        }

        public static void GetIFlyFromArrVeh(CVehicle[] arrVehicle, out /*IProcess*/IFly[] arrProcess)
        {
            IFly[] masFly = new IFly[arrVehicle.Length];
            int i = 0;
            foreach (var item in arrVehicle)
            {
                if (item is IFly)
                {
                    masFly[i++] = item as IFly;
                }
            }
            Array.Resize(ref masFly, i);
            arrProcess = masFly;
        }
        public delegate TResult Func<in T, out TResult>(T arg);
        public static void GetISwimFromArrVeh(CVehicle[] arrVehicle, out ISwim[] arrProcess)
        {
            ISwim[] masSwim = new ISwim[arrVehicle.Length];
            int i = 0;
            foreach (var item in arrVehicle)
            {
                if (item is ISwim)
                {
                    masSwim[i++] = item as ISwim;
                }
            }
            Array.Resize(ref masSwim, i);
            arrProcess = masSwim;
        }

}
}
