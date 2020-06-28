using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательность чисел через пробел: ");

            var inputData = Console.ReadLine();

            var splitedData = inputData.Split(' ');

            var posl = new int[splitedData.Length];

            for(int i = 0; i < splitedData.Length; i++)
            {
                posl[i] = int.Parse(splitedData[i]);
            }

            if (isProgress(posl) == 1) Console.WriteLine("Арифметическая прогрссия");
            else if (isProgress(posl) == -1) Console.WriteLine("Геометрическая прогрессия");
            else if (isProgress(posl) == 2) Console.WriteLine("Это арифметическая и геометричесская прогрессия");
            else Console.WriteLine("Это не арифметическая и не геометричесская прогрессия");
        }

        /// <summary>
        /// Определяет какой последовательностью является массив целых чисел
        /// </summary>
        /// <param name="arr">Массив целых числе</param>
        /// <returns> -1 - геометрическая, 1 - арифметическая, 0 - иная</returns>
        static int isProgress(int[] arr)
        {   if (isArifm(arr) && isGeometr(arr)) return 2;
            else if (isArifm(arr)) return 1;
            else if (isGeometr(arr)) return -1;
            
            return 0;
        }

        /// <summary>
        /// Проверка на арифметичную прогрессию
        /// </summary>
        /// <param name="arr">Массив целых чисел</param>
        /// <returns></returns>
        static bool isArifm(int[] arr)
        {
            var delta = arr[0] - arr[1];

            for(int i = 1; i < arr.Length -1 ; i++)
            {
                var delta1 = arr[i] - arr[i + 1];

                if (delta != delta1) return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка на геометрическую прогрессию
        /// </summary>
        /// <param name="arr">Массив целых чисел</param>
        /// <returns></returns>
        static bool isGeometr(int[] arr)
        {
            float delta = (float)arr[0] / (float)arr[1];

            for (int i = 1; i < arr.Length - 1; i++)
            {
                float delta1 = (float)arr[i] / (float)arr[i + 1];

                if (delta != delta1) return false;
            }

            return true;
        }
    }
}
