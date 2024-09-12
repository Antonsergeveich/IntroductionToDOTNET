
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
            Console.BufferWidth = Console.WindowWidth;   //Задаём размеры буффера чтобы он полностью совпадал с размерами экрана
            Console.BufferHeight = Console.WindowHeight;
            //Генерация случайного числа
            Random rand = new Random();             //1)Создаём объект класса 'Random'
            int x = rand.Next(Console.BufferWidth); //2)Метод Nexy() возвращает случайное число типа 'int'
            int y = rand.Next(Console.BufferHeight);
            Console.WriteLine($"X = {x}, Y = {y}");
            Console.SetCursorPosition(x, y);
            char symbol = (char)2;
            Console.WriteLine(symbol);
            ConsoleKey key;
            Console.CursorVisible = false;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                //Console.WriteLine(key.ToString());
                switch (key)
                {
                    //https://learn.microsoft.com/ru-ru/dotnet/api/system.consolekey?view=net-7.0
                    case ConsoleKey.UpArrow: // Чтобы перемещать смайлик стрелочками
                    case ConsoleKey.W: y--; break;
                    case ConsoleKey.DownArrow:
                    case ConsoleKey.S: y++; break;
                    case ConsoleKey.LeftArrow:
                    case ConsoleKey.A: x -= 2; break;
                    case ConsoleKey.RightArrow:
                    case ConsoleKey.D: x += 2; break;
                }
                if (y < 1) y = 1;
                if (x < 0) x = 0;
                if (y > Console.BufferHeight - 1) y = Console.BufferHeight - 1;
                if (x > Console.BufferWidth - 1) x = Console.BufferWidth - 1;
                Console.Clear();
                //https://learn.microsoft.com/ru-ru/dotnet/api/system.console.setcursorposition?view=netcore-3.1
                Console.SetCursorPosition(x, y);
                Console.Write(symbol);
            } while (key != ConsoleKey.Escape);
        }
    }
}