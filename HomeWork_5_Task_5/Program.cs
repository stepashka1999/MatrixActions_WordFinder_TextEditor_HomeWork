using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_5_Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Функция Аккермана");
            Console.WriteLine($"\n A(2, 5) = {Akkerman(2, 5)}");
            Console.WriteLine($"\n A(1, 2) = {Akkerman(1, 2)}");
            Console.WriteLine($"\n A(2, 1) = {Akkerman(2, 1)}");
        }

        /// <summary>
        /// Функция аккермана
        /// </summary>
        /// <param name="n"></param>
        /// <param name="m"></param>
        /// <returns></returns>
        static int Akkerman(int n, int m)
        {
            if (n == 0) return m + 1;
            else if ((n != 0) && (m == 0)) return Akkerman(n - 1, 1);
            else return Akkerman(n - 1, Akkerman(n, m - 1));
        }
    }
}
