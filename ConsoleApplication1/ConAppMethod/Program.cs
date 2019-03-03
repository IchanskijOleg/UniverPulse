using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppMethod
{
    class Program
    {
        /// <summary>
        /// Задолженость по кредиту
        /// </summary>
        /// <param name="payment">Сумма платежа</param>
        public static void GetSumDebt(int payment)
        {
            int totalSum = 1000;
            int payt = totalSum - payment;

            if (payt > 0)
            {
                Console.WriteLine("Задолженост сотавляет {0}грн", payt);
            }
            else if (payt < 0)
            {
                Console.WriteLine("Переплата сотавляет {0}грн", Math.Abs(payt));
            }
            else
            {
                Console.WriteLine("Задолженость отсутсвует");
            }
            Console.WriteLine();

        }

        public static int GetFactorial(int n)
        {
            int res = 1;
            //res = res * 2;
            //res = res * 3;
            if (n > 0)
            {
                res = res * GetFactorial(n - 1);
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("введите сумму платежа");
            int pay = Convert.ToInt32(Console.ReadLine());
            GetSumDebt(pay);

            Console.WriteLine("GetFactorial = {0}", GetFactorial(3));
            Console.ReadKey();
        }
    }
}
