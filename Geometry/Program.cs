//#define STARS
//#define HARDCHESS
#define HARDCHESS2
//#define CHESSBOARD
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

#if STARS
            #region ST
            //Console.WriteLine("Введите количество звёздочек: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("0)");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++) Console.Write('*');
            //    Console.WriteLine(" ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("1)");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++) Console.Write("*");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("2)");
            //for (int i = n; i > 0; i--)
            //{
            //    for (int j = n; j > 0; j--) Console.Write(j <= i ? "*" : "");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("3)");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++) Console.Write(j < i ? " " : "*");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("4)");
            //for (int i = n; i > 0; i--)
            //{
            //    for (int j = 0; j < n; j++) Console.Write(j < i - 1 ? " " : "*");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("5)"); 
            #endregion
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i; j < n; j++) Console.Write(j < n - 1 ? " " : "/");
            //    for (int j = 0; j <= i * 2; j++) Console.Write(j < i * 2 ? " " : "\\");
            //    Console.WriteLine();
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j <= i; j++) Console.Write(j <= i - 1 ? " " : "\\");
            //    for (int j = 0; j <= (n - 1 - i) * 2; j++) Console.Write(j < (n - 1 - i) * 2 ? " " : "/");
            //    Console.WriteLine();
            //}

            Console.Write("Введите размер фигуры: ");
            int x = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < x * 2; i++)
            {
                for(int j = 0; j < x * 2; j++)
                {
                    if (i < x && i == j - x  || i >= x && j == i - x) Console.Write("\\");
                    else if (i == x - 1 - j || i - x == x * 2 - 1 - j) Console.Write("/");
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); 


            //Console.WriteLine("6)");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++) Console.Write((i + j) % 2 == 0 ? "+ " : "- ");
            //    Console.WriteLine();
            //}
            //Console.WriteLine();
#endif

#if HARDCHESS
            Console.WriteLine("Введите размер доски: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("8)");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    for (int k = 0; k < size; k++)
                    {
                        for (int l = 0; l < size; l++)
                        {
                            Console.Write(i % 2 == k % 2 ? "* " : "  ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.WriteLine();  
#endif

#if HARDCHESS2
            Console.WriteLine("Введите размер доски: ");
            int size = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < size * size ; i++) 
            {
                for(int j = 0; j < size * size ; j++) 
                {
                    //https://learn.microsoft.com/ru-ru/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
                    bool a = Convert.ToBoolean(i / size & 1);
                    bool b = Convert.ToBoolean(j / size & 1);
                    Console.Write( a ^ b ? "* " : "  ");
                }
                Console.WriteLine();
            }
#endif

#if CHESSBOARD
            Console.WriteLine("Введите размер шахматной доски: ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("7)");
            for (int i = 0; i <= s; ++i)
            {
                for (int j = 0; j <= s; ++j)
                {
                    if ( i == 0 && j == 0) Console.Write(Convert.ToChar("┌"));      //charmap в поиске - таблица символов
                    else if ( i == 0 && j == s) Console.Write(Convert.ToChar("┐")); 
                    else if ( i == s && j == s) Console.Write(Convert.ToChar("┘")); 
                    else if ( i == s && j == 0) Console.Write(Convert.ToChar("└")); 
                    else if ( i == 0 || i == s) Console.Write(Convert.ToChar("─")); 
                    else if ( j == 0 || j == s) Console.Write(Convert.ToChar("│")); 
                    else Console.Write(i % 2 == j % 2 ? Convert.ToChar(0x2588) : ' ');
                }
                Console.WriteLine();
            }
#endif
        }
    }
}
