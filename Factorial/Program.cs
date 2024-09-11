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
                //https://ru.wikipedia.org/wiki/Длинная_арифметика
                //https://learn.microsoft.com/ru-ru/dotnet/api/system.numerics.biginteger?view=net-8.0
                //BigInteger — это встроенный тип в C#, который позволяет хранить и манипулировать большими целыми числами.
                //Он особенно полезен, когда стандартные числовые типы, такие как int или long, недостаточны для ваших потребностей.
                //Преимущества использования BigInteger:
                //— Обработка больших чисел, которые превышают диапазон стандартных числовых типов.
                //— Поддержка арифметических операций над большими целыми числами.
                //— Предоставление методов для генерации простых чисел, вычисления GCD и других.
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
