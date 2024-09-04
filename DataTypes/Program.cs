using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    internal class Program
    {
        static readonly string delimeter1 = "\n--------------------------------------\n";
        static readonly string delimeter2 = "\n======================================\n";
        static void Main(string[] args)
        {
            Console.WriteLine("C# DataTypes");

            #region Boolean
            //Console.WriteLine(bool.TrueString);
            //Console.WriteLine(Convert.ToBoolean(100));
            //Console.WriteLine(bool.Parse("false")); 
            #endregion

            #region Char
            //Unicode
            //Console.WriteLine(char.GetNumericValue(char.MinValue));
            //Console.WriteLine(char.GetNumericValue(char.MaxValue));
            //Console.WriteLine(char.MaxValue); 
            #endregion

            #region IntegralTypes
            //Console.Write($"Переменная типа 'char' занимает {sizeof(short)} Байт,");
            //Console.WriteLine($"и принимает значения в диапазоне: {short.MinValue} ... {short.MaxValue}");
            //Console.Write($"Диапазон принимаемых значений 'ushort': {ushort.MinValue} ... {ushort.MaxValue};");
            //Console.WriteLine(delimeter1);
            //Console.Write($"Переменная типа 'Int16' занимает {sizeof(Int16)} Байт,");
            //Console.WriteLine($"и принимает значения в диапазоне: {Int16.MinValue} ... {Int16.MaxValue}");
            //Console.Write($"Диапазон принимаемых значений 'Unit16': {UInt16.MinValue} ... {UInt16.MaxValue};");
            //Console.WriteLine();
            //Console.WriteLine(delimeter2);
            //
            //Console.Write($"Переменная типа 'int' занимает {sizeof(int)} Байт,");
            //Console.WriteLine($"и принимает значения в диапазоне: {int.MinValue} ... {int.MaxValue}");
            //Console.Write($"Диапазон принимаемых значений 'uint': {uint.MinValue} ... {uint.MaxValue};");
            //Console.WriteLine(delimeter1);
            //Console.Write($"Переменная типа 'Int32' занимает {sizeof(Int32)} Байт,");
            //Console.WriteLine($"и принимает значения в диапазоне: {Int32.MinValue} ... {Int32.MaxValue}");
            //Console.Write($"Диапазон принимаемых значений 'Unit32': {UInt32.MinValue} ... {UInt32.MaxValue};");
            //Console.WriteLine();
            //Console.WriteLine(delimeter2);
            //
            //Console.Write($"Переменная типа 'long' занимает {sizeof(long)} Байт,");
            //Console.WriteLine($"и принимает значения в диапазоне: {long.MinValue} ... {long.MaxValue}");
            //Console.Write($"Диапазон принимаемых значений 'ulong': {ulong.MinValue} ... {ulong.MaxValue};");
            //Console.WriteLine(delimeter1);
            //Console.Write($"Переменная типа 'Int64' занимает {sizeof(Int64)} Байт,");
            //Console.WriteLine($"и принимает значения в диапазоне: {Int64.MinValue} ... {Int64.MaxValue}");
            //Console.Write($"Диапазон принимаемых значений 'Unit64': {UInt64.MinValue} ... {UInt64.MaxValue};");
            //Console.WriteLine();
            //Console.WriteLine(delimeter2); 
            #endregion

            double a = 12.56;
            Console.WriteLine(a*100000);

        }
    }
}
