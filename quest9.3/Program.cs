using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest9._3
{
    internal class Program
    {
        //////////////////////////////////////////// 1 ////////////////////////////////////////////////

        static string MyReverse(int[] array)
        {
            for (int i = 0; i < array.Length; i++) { Console.Write(array[array.Length - i - 1] + " "); }
            return Convert.ToString(array.Reverse());
        }

        //////////////////////////////////////////// 2 ////////////////////////////////////////////////

        static void SubArray(int[] array, int index, int count)
        {
            int[] array_2 = new int[count];
            Console.WriteLine($"{count} элементов массива начиная с {index}");
            index--;
            for (int i = 0; i < array_2.Length; i++)
            {
                if (index < array.Length)
                {
                    array_2[i] = array[index];
                    index++;
                }
                else { array_2[i] = 1; }
                Console.Write(array_2[i] + " ");

            }

        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++) { array[i] = i + 1; }
            Console.Write("Элементы массива: ");
            for (int i = 0; i < array.Length; i++) { Console.Write(array[i] + " "); }

            Console.Write("\nЭлементы массива с конца: ");
            MyReverse(array);

            Console.WriteLine("\nВведите index и count");
            int index = int.Parse(Console.ReadLine()), count = int.Parse(Console.ReadLine());
            SubArray(array, index, count);

            Console.ReadKey();
        }
    }
}
