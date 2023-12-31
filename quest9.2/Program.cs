﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest9._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbs = new int[10]; // Создаём массив на 10 элементов
            numbs[0] = 12; numbs[1] = 59; numbs[2] = 38; numbs[3] = 93; numbs[4] = 43;
            numbs[5] = 45; numbs[6] = 76; numbs[7] = 52; numbs[8] = 96; numbs[9] = 10; // Заполняем его случайными числами


            Console.WriteLine($"Наибольшее значение массива: {numbs.Max()}"); 
            Console.WriteLine($"Наименьшее значение массива: {numbs.Min()}");
            Console.WriteLine($"Сумма всех значений в массиве: {numbs.Sum()}");
            Console.WriteLine($"Среднее арифметическое всех элементов: {numbs.Sum() / numbs.Length}");
            Console.Write($"Все нечётные элементы массива:");

            for (int i = 0; i < numbs.Length; i++) // По очереди обращаемся к элементам массива numbs
            {
                if (numbs[i] % 2 != 0) // Проверка элемента на чётность
                {
                    Console.Write($" {numbs[i]}"); // Вывод элемента
                }
            }

            Console.ReadKey();
        }
    }
}
