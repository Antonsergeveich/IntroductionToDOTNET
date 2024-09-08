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
            Console.WriteLine("Введите целое число от 0 до 65 включительно для вычисления факториала: ");
            int n = Convert.ToInt16(Console.ReadLine());
            ulong f = 1; //Факториал
            for (uint i = 1; i <= n; i++)
            {
                f *= i;
            }
            Console.WriteLine($"{n}! = {f}");
            Console.WriteLine();
        }
    }
}
