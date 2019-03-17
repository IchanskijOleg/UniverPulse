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
        /// Из Масива Vehicle получить масив Car //не старше 5 лет
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
        /// Виводимо на екран інформацію по транспортних засобах
        /// </summary>
        /// <param name="arrVehicle">Масив транспортних засібів</param>
        public static void PrintVehicleArr(CVehicle[] arrVehicle)
        {
            foreach (var item in arrVehicle)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
