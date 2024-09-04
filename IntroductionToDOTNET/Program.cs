//#define OUTPUT_TO_SCREEN
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
#if OUTPUT_TO_SCREEN
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

            #region ONE
            //Задаём размеры окна:
            //Console.WindowWidth = 64;
            //Console.WindowHeight = 16; 
            #endregion
            Console.SetWindowSize(64, 16);
            //Задаём положение окна на экране:
            // Console.WindowLeft = 10; 
            // Console.WindowTop = 10; 

            //Console.SetWindowPosition(10, 10);

            //Задаём размер буфера консоли:
            Console.BufferWidth = Console.WindowWidth;
            Console.BufferHeight = Console.WindowHeight; 
#endif
            Console.Write("Ввеедите Ваше имя: ");
            string first_name = Console.ReadLine(); // метод ReadLine() читает строку с клавиатуры до нажатия Enter
            // И возвращает прочитанную строку;
            //Console.WriteLine(first_name);

            Console.Write("Введите Вашу фамилию: ");
            string last_name = Console.ReadLine();
            //Console.WriteLine(last_name);

            Console.Write("Введите Ваш возраст: ");
            int age = Convert.ToInt32(Console.ReadLine());
            /*
              -----------------------------------------------
            Класс Convert представляет собой набор статических методов для преобразования типов.
            Этот класс используется как правило в том случае, когда другие преобразования не работают.
            ---------------------------------------------------
            */
            //Console.WriteLine(a);
            // Операции над строками:
            Console.WriteLine(last_name + " " + first_name + " " +  age + " years"); //Конкатенация строк
            // Кроме конкатенации строк C# поддерживает форматирование строк:
            Console.WriteLine(String.Format("{0} {1} {2} years", last_name, first_name, age));

            //Самая удобная операция - Интерполяция строк:
            Console.WriteLine($"{last_name} {first_name} {age} years");
        }
    }
}
