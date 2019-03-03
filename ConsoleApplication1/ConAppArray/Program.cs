using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppArray
{
    class Program
    {
        /// <summary>
        /// все элементы массива в обратном порядке
        /// </summary>
        /// <param name="arr">массив целых чисел</param>
        public static void MyReverse(int[] arr)
        {
            for (int i = arr.Length; i > 0; i--)
            {
                Console.WriteLine(arr[i - 1]);
            }
        }
        /// <summary>
        /// Максимальный елемент массива
        /// </summary>
        /// <param name="arr">массив целых чисел</param>
        public static void MaxElemArr(int[] arr)
        {
            int maxElArr = arr[0];
            int minElArr = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                maxElArr = Math.Max(maxElArr, arr[i]);
                minElArr = Math.Min(minElArr, arr[i]);
            }
            Console.WriteLine("Найбільший елемент масиву = {0}", maxElArr);
            Console.WriteLine("MIN елемент масиву = {0}", minElArr);
        }

        /// <summary>
        /// Вывод елементов массива на экан
        /// </summary>
        /// <param name="arr">массив целых чисел</param>
        public static void PrintArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        /// <summary>
        /// Вывод парных елементов массива
        /// </summary>
        /// <param name="arr">массив целых чисел</param>
        public static void PrintPairElemArr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        /// <summary>
        /// Метод возвращает часть полученного в качестве аргумента массива, 
        /// начиная с позиции указанной в аргументе index, 
        /// размерностью, которая соответствует значению аргумента count.  
        /// </summary>
        /// <param name="array">массив целых чисел</param>
        /// <param name="index">начало массива</param>
        /// <param name="count">к-во элементова масива</param>
        /// <returns></returns>
        public static int[] SubArray(int[] array, int index, int count)
        {
            int[] newArray = new int[count];
            if (index > count)
            {
                Console.WriteLine("index > count");
                return newArray;
            }
            for (int i = index, j = 0; j < count; i++, j++)
            {
                if (array.Length > i)
                {
                    newArray[j] = array[i];
                }
                else
                {
                    newArray[j] = 1;
                }
            }
            return newArray;
        }

        public static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] array1;
            MyReverse(array);
            MaxElemArr(array);
            array1 = SubArray(array, 5, 20);
            PrintArr(array1);
            Console.WriteLine(new string('-', 40));
            PrintPairElemArr(array);
            double d = 9 % 4;
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}
