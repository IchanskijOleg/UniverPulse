using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001ConAppVehicle
{
    static class CProgramSettings
    {
        /// <summary>
        /// Виводимо версію програми
        /// </summary>
        public static void PrintVersionProg()
        {
            Console.WriteLine(new string('+', 22));
            Console.WriteLine(new string('+', 5) + "RELEASE 1.00" + new string('+', 5));
            Console.WriteLine(new string('+', 22));
            Console.WriteLine();
        }
    }
}
