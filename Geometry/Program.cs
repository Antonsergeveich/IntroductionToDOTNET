using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        private static int n;
        static void Main(string[] args)
        {

            Console.WriteLine("Введите количество звёздочек: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("0)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write('*');
                Console.WriteLine(" ");
            }
            Console.WriteLine();
            Console.WriteLine("1)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write("*");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("2)");
            for (int i = n; i > 0; i--)
            {
                for (int j = n; j > 0; j--) Console.Write(j <= i ? "*" : "");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("3)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write(j < i ? " " : "*");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("4)");
            for (int i = n; i > 0; i--)
            {
                for (int j = 0; j < n; j++) Console.Write(j < i - 1 ? " " : "*");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("5)");
            for(int i = 0; i < n; i++)
            {
                for(int j = i; j < n; j++)Console.Write(j < n - 1 ? " " : "/"); 
                for(int j = 0; j <= i * 2; j++)Console.Write(j < i * 2  ? " " : "\\");
                Console.WriteLine();
            }
            for(int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++) Console.Write(j <= i - 1 ? " ": "\\");
                for(int j = 0; j < (n - 1 - i) * 2; j++)Console.Write(j < (n - 1 - i) * 2 - 1 ? " " : "/");    
                Console.WriteLine();
            }
            Console.WriteLine("6)");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) Console.Write((i + j) % 2 == 0 ? "+ " : "- ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
