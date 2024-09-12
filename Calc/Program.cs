using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите выражение: ");
                string expression = Console.ReadLine();
                Console.Write(expression + " = ");
                //https://learn.microsoft.com/ru-ru/dotnet/csharp/how-to/parse-strings-using-split
                String[] tokens = expression.Split('+', '-', '*', '/');
                for (int i = 0; i < tokens.Length; i++)
                {
                    Console.Write(tokens[i] + "\t");
                }
                Console.WriteLine();
                double a = Convert.ToDouble(tokens[0]);
                double b = Convert.ToDouble(tokens[1]);
                //https://learn.microsoft.com/ru-ru/dotnet/api/system.string.contains?view=net-8.0
                //Метод Contains() класса 'String' определяет, содержит ли строка указанный символ или подстроку.
                if (expression.Contains('+')) Console.WriteLine(a + b);
                else if (expression.Contains('-')) Console.WriteLine(a - b);
                else if (expression.Contains('*')) Console.WriteLine(a * b);
                else if (expression.Contains('/')) Console.WriteLine(a / b);
                else Console.WriteLine("No operation"); 
                // Бросает исключения если нет соответствующего знака в методе Split
                // Поэтому используем операторы обработки исключений try - catch
            }
            catch (Exception)
            {
                Console.WriteLine("No operation");
            }
        }
    }
}
