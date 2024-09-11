
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
            ConsoleKey key;
            #region MyRegion
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                Console.WriteLine(key.ToString());
            } while (key != ConsoleKey.Escape);
        #endregion

        https://learn.microsoft.com/ru-ru/dotnet/api/system.console.setcursorposition?view=netcore-3.1
            Console.SetCursorPosition(10, 10);
            key = Console.ReadKey(true).Key;
            do
            {
                switch (key)
                {
                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop); break;
                }
            } while (key != ConsoleKey.Escape);

        }


    }
}