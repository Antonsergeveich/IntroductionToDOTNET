#define ARRAYS1
#define ARRAYS2
#define JAGGED_ARRAYS
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
#if ARRAYS1 // Одномерный
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
            //https://stackoverflow.com/questions/2419343/how-to-sum-up-an-array-of-integers-in-c-sharp
            int sum = arr.Sum();
            Console.WriteLine($"Сумма элементов одномерного массива = {sum}");
            foreach (int i in arr) sum += i;
            Console.WriteLine($"Сумма элементов одномерного массива с использованием цикла foreach = {sum}");
#endif

#if ARRAYS2 // Двумерный
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
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    Console.Write(i_arr_2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            foreach (int i in i_arr_2)
            //foreach -  не различает строки и столбики и выводит многомерный массив как одномерный
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();

            //https://stackoverflow.com/questions/26290324/sum-of-all-numbers-in-a-multi-dimensional-array
            for (int i = 0; i < i_arr_2.GetLength(0); i++)
            {
                for (int j = 0; j < i_arr_2.GetLength(1); j++)
                {
                    sum += i_arr_2[i, j];
                }
            }
            Console.WriteLine($"Сумма элементов двумерного массива = {sum}");
            Console.WriteLine();
#endif
#if JAGGED_ARRAYS //Зубчатые массивы
            int[][] j_arr = new int[][]
            {
                new int[]{0,1,1,2},
                new int[]{3,5,8,13,21},
                new int[]{34,55,89},
                new int[]{144,233,377,610,987},
            };

            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    Console.Write(j_arr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            int sumj = 0;
            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    sumj += j_arr[i][j];
                }
            }
            Console.WriteLine($"Сумма элементов зубчатого массива = {sumj}");

#endif
        }
    }
}
