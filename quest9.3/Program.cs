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
            /// Выводим элементы массива с конца
            return null; // Ретёрн ради ретёрна
        }

        //////////////////////////////////////////// 2 ////////////////////////////////////////////////

        static void SubArray(int[] array, int index, int count)
        {
            int[] array_2 = new int[count]; // Создание массива размером с count
            Console.WriteLine($"{count} элементов массива начиная с {index}");

            index--;
            /// Если index равен 3, то записываться во второй массив будет
            /// записывать в себя значения начиная с индекса 3, 
            /// то есть по факту значение будет 4м по счёту, так что уменьшаем index на 1

            for (int i = 0; i < array_2.Length; i++) // Проходим по всем элементам второго массива по очереди
            {
                if (index < array.Length) // Если индекс больше длины первого массива, то...
                {
                    array_2[i] = array[index]; // ...значение второго массива равно значению первого по индексу
                    index++; // Увеличиваем index на один
                }
                else { array_2[i] = 0; } // Если индекс больше или равен длине первого массива, то элемент равен 0
                Console.Write(array_2[i] + " "); // Выводим элемент воторго массива

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
