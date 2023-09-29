using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quest9._3
{
    internal class Program
    {
        static string MyReverse(int[] array)
        {
            for (int i = 0; i < array.Length; i++) { Console.WriteLine(array[array.Length - i - 1]); }
            return Convert.ToString(array.Reverse());
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int[] intsubArray = new int[count - 1];                 // Новый массив для сохранения выбранных значений
            int k = 0;                                              // Переменная подсчёта для массива intSubArray
            for (int i = index; index < array.Length; i++)          // Начать выборку со значения index
            {
                intsubArray[k] = array[i];                          // Присвоение элементу нового массива под номером k
                                                                    //  значение элемента старого массива под номером i
                k++;                                                // В конце каждого выполнения цикла увеличение
                                                                    //  переменной подсчёта на 1
            }

            for (int j = 0; j < intsubArray.Length; j++) { Console.Write(intsubArray[j]); } // Вывод резулльтата
            return null;                                            // Ретёрн ради ретёрна
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
