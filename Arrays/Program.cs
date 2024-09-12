//#define ARRAYS1
#define ARRAYS2
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
#if ARRAYS1
            //int[] arr = new int[] { 3, 5, 8, 13, 21 };
            //int[] arr = { 3, 5, 8, 13, 21 };
            Console.Write("Введите количество элементов: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            //Заполнение массива случайными числами:
            Random rand = new Random(0); // '0' для того чтобы генерировать одни и те же случайные числа
            for (int i = 0; i < arr.Length; i++)
            {
                //https://learn.microsoft.com/ru-ru/dotnet/api/system.random.next?view=net-8.0
                arr[i] = rand.Next(50, 100);
            }

            //Вывод массива на экран:
            for (int i = 0; i < arr.Length; i++) //Свойства Length содержат длину массива
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            /*
            ------------------------------------
            foreach(Type iterator in collection)
            {
                ...........;
                ...........;
            }
            ------------------------------------
            */ 
#endif

#if ARRAYS2
            //int[,] i_arr_2 = new int[3, 4]; // Размерность двумерного массива
            int[,] i_arr_2 = new int[,]
            {
                {3,5,8,13 },
                {21,34,55,89},
                {144,233,377,610}
            };
            //Console.WriteLine(i_arr_2.Rank); //Rank - показывает количество измерений
            //Console.WriteLine((new int[5]).Rank);
            //Console.WriteLine((new int[2,3,4,5]).Rank);

            Console.WriteLine($"Количество измерений массива: {i_arr_2.Rank}");
            Console.WriteLine($"Количество элементов в нулевом измерении (количество строк): {i_arr_2.GetLength(0)}");
            Console.WriteLine($"Количество элементов в первом измерении (количество столбцов): {i_arr_2.GetLength(1)}");
            for ( int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for( int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i,j] + "\t");
                }
                Console.WriteLine();
            }
#endif
        }
    }
}
