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
                if (item.Speed > res.Speed)
                {
                    res = item;
                }
            }
            Console.WriteLine("Найбільша швидкість складає {0}. Тз \"{1}\".", res.Speed, res.Name);
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
                    Console.WriteLine("Транспортний засіб \"{0}\" року виробництва {1}.", item.Name, item.YearIssue);
                }
            }
        }
    }
}
