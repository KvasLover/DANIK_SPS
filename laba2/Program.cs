using System;
using System.Text;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)

            //a)

            
            bool a = false;

            Console.Write("bool ('t'=true, 'f'=false): ");
            char temp = Convert.ToChar(Console.ReadLine());
            if (temp == 't')
                a = true;
            else if (temp == 'f')
                a = false;
            else
                Console.WriteLine("Invalid value!");

            Console.Write("byte: ");
            byte b = Convert.ToByte(Console.ReadLine());
            Console.Write("sbyte: ");
            sbyte c = Convert.ToSByte(Console.ReadLine());
            Console.Write("char: ");
            char d = Console.ReadLine()[0];
            Console.Write("decimal: ");
            decimal e = Convert.ToDecimal(Console.ReadLine());
            Console.Write("double: ");
            double f = Convert.ToDouble(Console.ReadLine());
            Console.Write("float: ");
            float g = (float)Convert.ToSingle(Console.ReadLine());
            Console.Write("int: ");
            int h = Convert.ToInt32(Console.ReadLine()); ;
            Console.Write("uint: ");
            uint i = Convert.ToUInt32(Console.ReadLine());
            Console.Write("long: ");
            long j = (long)Convert.ToInt32(Console.ReadLine());
            Console.Write("ulong: ");
            ulong k = (ulong)Convert.ToInt32(Console.ReadLine());
            Console.Write("short: ");
            short l = (short)Convert.ToInt32(Console.ReadLine());
            Console.Write("ushort: ");
            ushort m = (ushort)Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nbool -\t{a}");
            Console.WriteLine($"byte -\t{b}");
            Console.WriteLine($"sbyte -\t{c}");
            Console.WriteLine($"char -\t{d}");
            Console.WriteLine($"decimal -\t{e}");
            Console.WriteLine($"double -\t{f}");
            Console.WriteLine($"float -\t{g}");
            Console.WriteLine($"int -\t{h}");
            Console.WriteLine($"uint -\t{i}");
            Console.WriteLine($"long -\t{j}");
            Console.WriteLine($"ulong -\t{k}");
            Console.WriteLine($"short -\t{l}");
            Console.WriteLine($"ushort -\t{m}");

            //b)

            byte a1 = 1, b1 = 2;
            double c1 = a1;
            float d1 = b1;
            long e1 = a1;
            short f1 = b1;
            int g1 = a1;

            Console.WriteLine($"c1 = {c1}, d1 = {d1}, e1 = {e1}, f1 = {f1}, g1 = {g1}");

            //c)

            int a3 = 10;
            object b3 = a3;

            int c3 = (int)b3;

            //d)

            var a4 = 10;
            var b4 = "text";

            //e)

            int? a5 = null;
            Console.WriteLine($"Nullable vadiable a = {a5}");

            //f)

            var a6 = 10;
            a6 = 'a';
            Console.WriteLine($"a6 = {a6}");

            //2)

            //a)

            string a7 = "string", b7 = "string";
            int c7 = String.Compare(a7, b7);
            Console.WriteLine($"Compare result (0 - same, -1 - not): {c7}");

            //b)

            string a8, b8, c8; //СЦЕПЛЕНИЕ
            Console.WriteLine($"Enter a8: ");
            a8 = Console.ReadLine();
            Console.WriteLine($"Enter b8: ");
            b8 = Console.ReadLine();
            Console.WriteLine($"Enter c8: ");
            c8 = Console.ReadLine();
            Console.WriteLine($"a8 + b8 + c8 = {a8 + b8 + c8}");

            Console.Write("Enter a string: "); //КОПИРОВАНИЕ
            string e8 = Console.ReadLine();
            string f8 = String.Copy(e8);
            Console.WriteLine($"Copied string: {f8}");

            string g8 = "one two three"; //ВЫДЕЛЕНИЕ ПОДСТРОКИ
            string h8 = g8.Substring(5, 4);
            Console.WriteLine($"String: {g8}\nCopied substring: {h8}");

            Console.Write("Enter a string of some words: "); //РАЗДЕЛЕНИЕ НА СЛОВА          
            string d8 = Console.ReadLine();
            for (int i = 0; i < d8.Length; i++)
            {
                if (d8[i] == ' ')
                {
                    Console.WriteLine("");
                    continue;
                }
                Console.Write($"{d8[i]}");
            }
            Console.WriteLine("");

            g8 = g8.Insert(0, h8); //ВСТАВКА ПОДСТРОКИ В СТРОКУ
            Console.WriteLine($"String with added substring: {g8}");

            g8 = g8.Remove(0, h8.Length); //УДАЛЕНИЕ ПОДСТРОКИ
            Console.WriteLine($"Fixed string after removing a substring: {g8}");

            //с)

            string a9 = "", b9 = null, c9 = "string";
            Console.WriteLine($"{String.IsNullOrEmpty(a9)}\n{String.IsNullOrEmpty(b9)}\n{String.IsNullOrEmpty(c9)}\nLength of '' string: {a9.Length}\n'null' string: {b9}");


        }
    }
}
