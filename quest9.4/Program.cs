using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest9._4
{
    internal class Program
    {
        static void ArrayLenght(int[] array) 
        {
            int[] array_2 = new int[array.Length + 1]; 
            // Создаём второй массив размером больше первого на 1 элемент

            array_2[array.Length] = 0; // Последний элемент второго массива равен 0

            for (int i = 0; i < array.Length; i++) { array_2[i] = array[i]; } 
            // Записываем элементы второго массива в первый с сохранением индекса
            
            for (int i = 0; i < array_2.Length; i++) { Console.Write(array_2[i] + " "); } 
            // Выводим все элементы второго массива по очереди

        }

        static void SubArray_2(int[] array, int value)
        {
            int[] array_2 = new int[array.Length + 1];
            // Создаём второй массив размером больше первого на 1 элемент
            array_2[0] = value; // Нулевой элемент массива равен переданному значению

            for (int i = 0; i < array.Length; i++) { array_2[i + 1] = array[i]; }
            // Записываем элементы второго массива в первый со сдвигом индекса

            for (int i = 0; i < array_2.Length; i++) { Console.Write(array_2[i] + " "); }
            // Выводим все элементы второго массива по очереди

        }

        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++) { array[i] = i + 1; }

            Console.Write("Введите value: ");
            int value = int.Parse(Console.ReadLine());
            SubArray_2(array, value);

            Console.WriteLine("\nМассив, увеличенный на 1 с сохранением индексов эл-в: ");
            ArrayLenght(array);
            Console.ReadKey();
        }
    }
}
