using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char aba = 'A';
            int cnt = 257;
            byte s = (byte)cnt;  
            Console.WriteLine(s);
            Console.WriteLine(aba);
            Console.WriteLine("Hello World");
            Console.Write(8);

            Console.WriteLine(new string('-', 40));
            byte x = 5, y = 2;
            double d = x / y;
            double d1 = x % y;
            Console.WriteLine(d);
            Console.WriteLine(d1);

            d1 = Math.Pow(x, y);
            bool b = false;
            b = 0 < 1;
            Console.WriteLine(b);

            x = 255;
            byte n = (byte)(x + y);
            int n_int = (x + y);
            Console.WriteLine("n=" + n + "n_int=" + n_int);
            int c = 5;
            c += 5;
            Console.WriteLine(c);
            {
                int a;
                c = 0;
            }

            sbyte e = 127;
            unchecked
            {
                e++;
            }
            Console.WriteLine(e);

            Console.WriteLine("e=" + e);
            c = (20 > 8) 
                ? e = 66 
                : 100;
            Console.WriteLine(c);
            Console.WriteLine(e);

            Console.WriteLine("vvedit polzovatela");
            string userName = Console.ReadLine();
            string r = "Hello";
            r += userName == "Oleg" ? "Ura" : "chort";
            Console.WriteLine(r);
            x = 4; y = 2;
            //c = x > y ? (x == 0 ? 9 : 7) : 6 : 5; 

            switch (x)
            {
                case 1:
                    {
                        Console.WriteLine(1);
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine(2);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("not sovpadenij");
                    }
                    break;
            }

            x = 1; y = 0;

            Console.WriteLine("vvedit cislo");
            int k = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine("x > y");
            }
            else if (x == y)
            {
                Console.WriteLine("x = y");
            }
            else
            {
                Console.WriteLine("x < y");
            }

            Console.ReadKey();
        }
    }
}
