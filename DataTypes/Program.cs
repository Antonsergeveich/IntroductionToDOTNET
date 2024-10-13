//#define LITERALS
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

#if NUMERIC_TYPES

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

            // Console.Write($"Переменная типа 'float' занимает {sizeof(float)} Байт,");
            // Console.WriteLine($"и принимает значения в диапазоне: {Single.MinValue} ... {Single.MaxValue}");
            // Console.Write($"Диапазон принимаемых значений 'ulong': {Single.MinValue} ... {Single.MaxValue};");
            // Console.WriteLine(delimeter1);
            // Console.Write($"Переменная типа 'Int64' занимает {sizeof(Int64)} Байт,");
            // Console.WriteLine($"и принимает значения в диапазоне: {Int64.MinValue} ... {Int64.MaxValue}");
            // Console.Write($"Диапазон принимаемых значений 'Unit64': {UInt64.MinValue} ... {UInt64.MaxValue};");
            // Console.WriteLine();
            // Console.WriteLine(delimeter2); 
            #endregion

            //double a = 12.56;
            //Console.WriteLine(a*100000);
            //Single precision
			Console.Write($"Переменная типа 'float' занимает {sizeof(float)} Байта памяти,");
			Console.WriteLine($"и принимает значения в диапазоне: {float.MinValue} ... {float.MaxValue}.");
			Console.WriteLine(delimiter1);
			Console.Write($"Переменная типа 'Single' занимает {sizeof(Single)} Байта памяти,");
			Console.WriteLine($"и принимает значения в диапазоне: {Single.MinValue} ... {Single.MaxValue}.");
			Console.WriteLine();
			Console.WriteLine(delimiter2);

			Console.Write($"Переменная типа 'double' занимает {sizeof(double)} Байта памяти,");
			Console.WriteLine($"и принимает значения в диапазоне: {double.MinValue} ... {double.MaxValue}.");
			Console.WriteLine(delimiter1);
			Console.Write($"Переменная типа 'Double' занимает {sizeof(Double)} Байта памяти,");
			Console.WriteLine($"и принимает значения в диапазоне: {Double.MinValue} ... {Double.MaxValue}.");
			Console.WriteLine();
			Console.WriteLine(delimiter2);

			//						Decimal
			Console.WriteLine($"Переменная типа 'decimal' занимает {sizeof(decimal)} Байта памяти,");
			Console.WriteLine($"и принимает значения в диапазоне: {decimal.MinValue} ... {decimal.MaxValue}.");
			Console.WriteLine(delimiter1);
			Console.WriteLine($"Переменная типа 'Decimal' занимает {sizeof(Decimal)} Байта памяти,");
			Console.WriteLine($"и принимает значения в диапазоне: {Decimal.MinValue} ... {Decimal.MaxValue}.");
			Console.WriteLine();
			Console.WriteLine(delimiter2); 
#endif
#if LITERALS
            Console.WriteLine(123.GetType().Name);     //int
            Console.WriteLine(123.4f.GetType().Name);  //float
            Console.WriteLine(123f.GetType().Name);    //float
            Console.WriteLine(123.4.GetType().Name);   //double
            Console.WriteLine(5d.GetType().Name);   //double
            Console.WriteLine(123.4m.GetType().Name);  //decimal
            Console.WriteLine(123m.GetType().Name);    //decimal
            Console.WriteLine(123L.GetType().Name);    //long
            Console.WriteLine(123ul.GetType().Name);   //long
            Console.WriteLine(delimeter1);
            Console.WriteLine('+'.GetType());
            Console.WriteLine("Hello".GetType()); 
            //typeid => GetType()		object
			Console.WriteLine(123.GetType());   //int
			Console.WriteLine(123u.GetType());   //int
			Console.WriteLine(123l.GetType());  //long
			Console.WriteLine(123UL.GetType());  //long
			Console.WriteLine(delimiter1);
			Console.WriteLine(5d.GetType());    //double
			Console.WriteLine(123.4.GetType()); //double
			Console.WriteLine(123.4f.GetType());//float
			Console.WriteLine(123f.GetType());  //float
			Console.WriteLine(123m.GetType());  //decimal
			Console.WriteLine(delimiter1);
			Console.WriteLine('+'.GetType());
			Console.WriteLine("Hello".GetType()); 
#endif
            
            #region Conversions1
            //Type conversion (type cast)
            //Console.WriteLine(((byte)5).GetType().Name);
            ////C-like notation: (type)value;
            //int a = 2;
            //int b = 3;
            //Console.WriteLine(a+"\t"+b);
            //a = (int)b;
            //Console.WriteLine(a+"\t"+b);
            //byte c = 2;
            //uint d = uint.MaxValue;
            #endregion
            //c = (byte)d; //Truncation; 
            //byte a = 2;
            //uint b = uint.MaxValue;
            //Console.WriteLine(a + "\t" + b);
            //a = (byte)b;	//Truncation - усечение.
            //Урезается либо дробная часть при записи дробного числа в целочиленную переменную,
            // либо старшие байты целого числа, при записи его меньшую целочисленную переменную.
            //Console.WriteLine(a + "\t" + b); 

            try
            {
                int a = int.MaxValue;
                uint b = uint.MaxValue;
                Console.WriteLine(a + b);
                Console.WriteLine((a + b).GetType().Name);
                long c = long.MaxValue;
                Console.WriteLine(b + c);
                Console.WriteLine((b + c).GetType());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Buy");
        }
    }
}
