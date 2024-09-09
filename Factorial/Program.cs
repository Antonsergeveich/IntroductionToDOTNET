using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите целое число для вычисления факториала: ");
                int n = Convert.ToInt16(Console.ReadLine());
                BigInteger f = 1; //Факториал
                for (int i = 1; i <= n; i++)
                {
                    f *= i;
                    Console.WriteLine($"{n}! = {f}");
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
