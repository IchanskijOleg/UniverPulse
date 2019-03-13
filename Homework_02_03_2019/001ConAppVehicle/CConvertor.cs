using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    class CConvertor
    {
        /// <summary>
        /// Конвертуємо величини швидкості
        /// </summary>
        /// <param name="fromMeasure">Вхідна величина яку конвертуємо</param>
        /// <param name="fromValue">Значення вхідної величини</param>
        /// <param name="toMeasure">>Вихідна величина в яку конвертуємо</param>
        /// <returns>Швидкість у вихідній величині</returns>
        public static double SpeedConvert(SpeedMeasurement fromMeasure, double fromValue, SpeedMeasurement toMeasure)
        {
            double result = 0;
            if (fromMeasure == toMeasure)
            {
                result = fromValue;
            }
            else if (fromMeasure == SpeedMeasurement.km && toMeasure == SpeedMeasurement.m)
            {
                result = fromValue / 1.852;
            }
            else if (fromMeasure == SpeedMeasurement.m && toMeasure == SpeedMeasurement.km)
            {
                result = fromValue * 1.852;
            }
            return result;
        }
    }
}
