using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAME
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char key;
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
                //Console.WriteLine(key);
                //ConsoleKey.
                Console.WriteLine(key.ToString());
            }while (key != ConsoleKey.Escape);
        }
    }
}
