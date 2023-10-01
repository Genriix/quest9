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
            for (int i = 0; i < array.Length; i++) { Console.WriteLine(array[array.Length - i - 1]); }
            return Convert.ToString(array.Reverse());
        }

        //////////////////////////////////////////// 2 ////////////////////////////////////////////////

        static void SubArray(int[] array, int index, int count)
        {
            int[] array_2 = new int[count];
            for (int i = 0; i < array.Length; i++) { array[i] = i; }
            for (int i = 0; i == 0; i++)
            {
                Console.WriteLine("\n");
                var slice = array[index = (count + 1)];
                Console.WriteLine("Элементы массива, начиная с " + index + " заканчивая ограничением " + count + " :");
                Console.WriteLine(String.Join(", ", slice));
            }
            Console.WriteLine("Новый массив:");
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
            for (int i = 0; i < array.Length; i++) { Console.WriteLine(array[array.Length - i - 1]); }

            MyReverse(array);
            SubArray(array, 2, 5);

        }
    }
}
