
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
           // Console.
        //Генерация случайного числа
        Random rand = new Random(); //1)Создаём объект класса 'Random'
        int x = rand.Next(Console.BufferWidth);        //2)Метод Nexy() возвращает случайное число типа 'int'
        int y = rand.Next(Console.BufferHeight);
            Console.WriteLine($"X={x}, Y={y}");
            Console.SetCursorPosition(x, y);
            char symbol =(char) 2;
        Console.WriteLine((char)2);

            ConsoleKey key;
            #region MyRegion
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                //Console.WriteLine(key.ToString());
                switch (key) 
                {
                    case ConsoleKey.UpArrow:
                    
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.A: x-=2; break;
                    case ConsoleKey.D: x+=2; break;
                }
                Console.SetCursorPosition(x, y);
                Console.WriteLine(symbol);
                Console.Clear();
            } while (key != ConsoleKey.Escape);
        #endregion

        //https://learn.microsoft.com/ru-ru/dotnet/api/system.console.setcursorposition?view=netcore-3.1
        //    Console.SetCursorPosition(10, 10);
        //    key = Console.ReadKey(true).Key;
        //    do
        //    {
        //        switch (key)
        //        {
        //            case ConsoleKey.DownArrow:
        //                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
        //            case ConsoleKey.UpArrow:
        //                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
        //            case ConsoleKey.RightArrow:
        //                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
        //            case ConsoleKey.LeftArrow:
        //                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
        //        }
        //    } while (key != ConsoleKey.Escape);

        }


    }
}