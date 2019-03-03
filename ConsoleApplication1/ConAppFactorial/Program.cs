using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppFactorial
{
    class Program
    {
        static int res ;
        /// <summary>
        /// Нахождение факториала
        /// </summary>
        /// <param name="d">Число факториала</param>
        /// <returns>Возвращает фактоиал</returns>
        static int GetFactorial(int d)
        {
            if (d == 0)
            {
                return 1;
            }

            int res = 1;
            for (int i = 1; i <= d; i++)
            {
                res = res * i;
            }
            return res;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введіть число");
            int f = Convert.ToInt32(Console.ReadLine());
            //int res = 1;

            if (f == 0)
            {
                Console.WriteLine("{0}! = {1}", f, res);
                return;
            }

            for (int i = 1; i <= f; i++)
            {
                res = res * i;
            }

            Console.WriteLine("{0}! = {1}", f, res);
            Console.WriteLine("GetFactorial: {0}! = {1}", f, GetFactorial(f));
            Console.ReadKey();
        }
    }
}
