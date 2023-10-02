using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; 
            // Создаём массив на 10 элементов
            for (int i = 0; i < array.Length; i++) { array[i] = i + 1; } 
            // Заполняем массив с 1 до 10
            for (int i = 0; i < array.Length; i++) { Console.WriteLine(array[array.Length - i - 1]); } 
            // Выводим элементы в обратном порядке
            Console.ReadKey(); 

        }
    }
}
