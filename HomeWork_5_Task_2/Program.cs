using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку: ");
            var str = Console.ReadLine();

            var res = MaxWord(str);

            for(int i = 0; i < res.Length; i++)
            {
                if (i != res.Length - 1) Console.Write(res[i] + ", ");
                else Console.WriteLine(res[i]);
            }
        }

        /// <summary>
        /// Ищет слово максимальной длинны в строке
        /// </summary>
        /// <param name="str"></param>
        /// <returns>Строку или массив строк со словом или словами максимальной длинны</returns>
        static string[] MaxWord(string str)
        {
            char[] splitters = { ' ', '.', ',' };

            var splitedStr = str.Split(splitters);

            var res = splitedStr.ToList();

            res.RemoveAll(x => x == string.Empty || x == " ");

            List<string> maxWrd = new List<string>();
            maxWrd.Add("");
            foreach(var item in res)
            {
                if (item.Length > maxWrd[0].Length)
                {
                    maxWrd.Clear();
                    maxWrd.Add(item);
                }
                else if(item.Length == maxWrd[0].Length) maxWrd.Add(item);
            }

            var result = maxWrd.ToArray();

            return result;
        }
    }
}
