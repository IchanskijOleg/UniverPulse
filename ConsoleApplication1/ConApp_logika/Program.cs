using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_logika
{
    class Program
    {
        static void Main(string[] args)
        {
            byte f = 1 | 2;
            Console.WriteLine(f);

            byte j = 1 & 2;
            Console.WriteLine(j);

            byte k = 1 ^ 2;
            Console.WriteLine(k);

            sbyte m = ~1;
            Console.WriteLine(m);

            int l = 0x01;
            l += ~l;
            Console.WriteLine(l);

            m = 0;
            //l = 9 / m;
            Console.WriteLine(new String('-', 50));

            bool b1 = true, 
                 b2 = false;
            if ( ( b1 && !b2 ) == !( !b1 || b2 ) )
            {
                Console.WriteLine("IF");
            }
            else
            {
                Console.WriteLine("ELSE");
            }

            Console.ReadKey();
        }
    }
}
