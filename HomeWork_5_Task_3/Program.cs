using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");

            var inputStr = Console.ReadLine();

            if (string.IsNullOrEmpty(inputStr)) Console.WriteLine("Введенная строка пустая");
            else
            {
                var outputStr = SkipSameChar(inputStr);
                Console.WriteLine(outputStr);
            }

        }

        /// <summary>
        /// Удаляет одинаковые буквы в словах
        /// </summary>
        /// <param name="str">Строка</param>
        /// <returns>Новую строку без повторяющихся букв</returns>
        static string SkipSameChar(string str)
        {
            string result = "" + str[0];
            
            for(int i = 1; i < str.Length; i++)
            {
                var chr1 = str[i].ToString().ToLower();
                var chr2 = str[i - 1].ToString().ToLower();

                if (chr1.Equals(chr2)) continue;

                result += str[i];
            }

            return result;
        }
    }
}
