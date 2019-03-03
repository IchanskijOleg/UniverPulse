using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCuklu
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
        alex:
            if(i == 0)
            {
                i++;
                goto alex;
            }

            Console.WriteLine(new string('-',50));
            int counter=0;
            while (counter < 5)
            {
                counter++;
                Console.WriteLine("counter = {0}", counter);
            }

            Console.WriteLine("END");

            counter = 0;
            do
            {
                counter++;
                Console.WriteLine("do_counter = {0}", counter);
            } while (counter < 5);


            Console.WriteLine(new string('-', 50));
            for (int k = 0; k < 4; k++)
            {
                Console.WriteLine("k={0}",k);
            }

            Console.WriteLine(new string('*', 50));
            for (int l = 0; l < 3; l++)
            {
                switch (l)
                {
                    case 1:
                        {
                            Console.WriteLine(l);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine(l);
                            continue;
                        }
                    default:
                        break;
                }
            }
            Console.ReadKey();            
        }

    }
}
