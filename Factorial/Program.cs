using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число до 20 включительно для вычисления факториала: ");
            int n = Convert.ToInt16(Console.ReadLine());
            long f = 1; //Факториал
            for (int i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine($"{n}! = {f}");
            Console.WriteLine();
        }
    }
}
