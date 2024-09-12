using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1) Single dimensional;
//2) Multi dimensional;
//3) Jagged;



namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] { 3, 5, 8, 13, 21 };
            //int[] arr = { 3, 5, 8, 13, 21 };
            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            //Заполнение массива случайными числами:
            Random rand = new Random(0); // '0' для того чтобы генерировать одни ите же случайные числа
            for (int i = 0; i < arr.Length; i++)
            {
                //https://learn.microsoft.com/ru-ru/dotnet/api/system.random.next?view=net-8.0
                arr[i] = rand.Next(50,100);
            }

            //Вывод массива на экран:
            for (int i = 0; i < arr.Length; i++) //Свойства Length содержат длину массива
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
