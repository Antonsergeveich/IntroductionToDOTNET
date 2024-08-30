using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToDOTNET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Introduction to .NET";// Titel задаёт заголовок окна консоли
            //Console.Write("Hello .NET");   // выводит строку на экран
            Console.WriteLine("Hello .NET"); //выводит строку на экран и переходит вначало новой строки
            Console.BackgroundColor = ConsoleColor.Blue; //цвет фона
            Console.ForegroundColor = ConsoleColor.Black;

            //Console.CursorLeft = 24; // координата курсора по оси X
            //Console.CursorTop = 5; //координата курсора по оси Y
            Console.SetCursorPosition(16, 5);
            Console.WriteLine("Вот так задаются координаты");
            Console.ResetColor(); // применяет цветовую схему по умолчанию

            //Задаём размеры окна:
            //Console.WindowWidth = 64;
            //Console.WindowHeight = 16;
            Console.SetWindowSize(64, 16);
            //Задаём положение окна на экране:
            // Console.WindowLeft = 10; 
            // Console.WindowTop = 10; 

            //Console.SetWindowPosition(10, 10);

            //Задаём размер буфера консоли:
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight;
        }
    }
}
