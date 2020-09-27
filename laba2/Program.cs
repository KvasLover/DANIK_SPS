using System;
using System.Runtime.Serialization.Formatters;
using System.Text;

namespace laba2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   //1) ТИПЫ

               //a) ОПРЕДЕЛИТЬ, ВВЕСТИ, ВЫВЕСТИ

               Console.WriteLine("1)\n");
               Console.WriteLine("a)\n");

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

               Console.WriteLine();

               //b) 5 ЯВНЫХ И 5 НЕЯВНЫХ ПРЕОБРАЗОВАНИЙ

               Console.WriteLine("b)\n");

               byte a1 = 1, b1 = 2;
               double c1 = a1;
               float d1 = b1;
               long e1 = a1;
               short f1 = b1;
               int g1 = a1;

               Console.WriteLine($"c1 = {c1}, d1 = {d1}, e1 = {e1}, f1 = {f1}, g1 = {g1}");

               Console.WriteLine();

               //c) УПАКОВКА И РАСПАКОВКА

               int a3 = 10;
               object b3 = a3;

               int c3 = (int)b3;

               //d) НЕЯВНО ТИПИЗИРОВАННАЯ ПЕРЕМЕННАЯ

               var a4 = 10;
               var b4 = "text";

               //e) Nullable

               Console.WriteLine("e)\n");

               int? a5 = null;
               Console.WriteLine($"Nullable vadiable a = {a5}");

               Console.WriteLine();


               //f) МАНИПУЛЯЦИИ С var

               Console.WriteLine("f)\n");

               var a6 = 10;
               a6 = 'a';
               Console.WriteLine($"a6 = {a6}");

               Console.WriteLine();

   //2) СТРОКИ

               Console.WriteLine("2)\n");
               Console.WriteLine("a)\n");

               //a) ОБЪЯВИТЬ, СРАВНИТЬ

               string a7 = "string", b7 = "string";
               int c7 = String.Compare(a7, b7);
               Console.WriteLine($"Compare result (0 - same, -1 - not): {c7}");

               Console.WriteLine();

               //b) СЦЕПЛЕНИЕ, КОПИРОВАНИЕ, ВЫДЕЛЕНИЕ ПОДСТРОКИ, РАЗДЕЛЕНИЕ НА СЛОВА, ВСТАВКА ПОДСТРОКИ, УДАЛЕНИЕ ПОДСТРОКИ

               Console.WriteLine("b)\n");

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
               for (int i2 = 0; i2 < d8.Length; i2++)
               {
                   if (d8[i2] == ' ')
                   {
                       Console.WriteLine();
                       continue;
                   }
                   Console.Write($"{d8[i2]}");
               }
               Console.WriteLine("");

               g8 = g8.Insert(0, h8); //ВСТАВКА ПОДСТРОКИ В СТРОКУ
               Console.WriteLine($"String with added substring: {g8}");

               g8 = g8.Remove(0, h8.Length); //УДАЛЕНИЕ ПОДСТРОКИ
               Console.WriteLine($"Fixed string after removing a substring: {g8}");

               Console.WriteLine();

               //с) empty и null

               Console.WriteLine("c)\n");

               string a9 = "", b9 = null, c9 = "string";
               Console.WriteLine($"{String.IsNullOrEmpty(a9)}\n{String.IsNullOrEmpty(b9)}\n{String.IsNullOrEmpty(c9)}\nLength of '' string: {a9.Length}\n'null' string: {b9}");

               Console.WriteLine();

               //d) StringBuidler, УДАЛЕНИЕ ПОЗИЦИЙ, ДОБАВЛЕНИЕ В НАЧАЛО И В КОНЕЦ

               Console.WriteLine("d)\n");

               StringBuilder a10 = new StringBuilder("Hey, I am a string!", 50);
               Console.WriteLine($"String created with StringBuilder: {a10}");
               a10.Remove(0, 5);
               Console.WriteLine($"Without some elements: {a10}");
               a10.Insert(0, "Hello, ");
               Console.WriteLine($"With some elements in the tail: {a10}");
               Console.WriteLine($"With some elements in the head: {a10 + " Don't delete me!"}");

               Console.WriteLine();

   //3) МАССИВЫ

               Console.WriteLine("3)\n");
               Console.WriteLine("a)\n");

               //a) СОЗДАТЬ, ВЫВЕСТИ

               int[,] Array =
               {
                   {1,2},
                   {3,4}
               };
               for (int i11 =0; i11 < 2; i11++)
               {
                   for (int j11 = 0; j11 < 2; j11++)
                   {
                       Console.Write($"{Array[i11, j11]} ");
                   }
                   Console.WriteLine();
               }

               Console.WriteLine();

               //b) МАССИВ СТРОК, ВЫВЕСТИ СОДЕРЖИМОЕ, ДЛИНУ, ПОМЕНЯТЬ ЭЛ_Т

               Console.WriteLine("b)\n");

               string[] Array2 = {"string1","string2","string3","string4"};            
               for (int i12 =0; i12 < 4; i12++)
               {   
                   Console.Write($"{Array2[i]} ");
               }
               Console.WriteLine();
               Console.WriteLine($"Длина массива строк: {Array2.Length}");
               Console.Write($"Элемент под каким номером удалить? ");
               int a12 = Convert.ToInt32(Console.ReadLine()) - 1;
               Console.WriteLine($"Новое значение элемента под номером {a12+1}: ");
               string b12 = Console.ReadLine();
               Array2[a12] = b12;
               Console.WriteLine($"Отредактированный массив: ");
               for (int i1 = 0; i1 < 4; i1++)
               {
                   Console.Write($"{Array2[i1]} ");
               }

               Console.WriteLine();

               //c) СТУПЕНЧАТЫЙ

               Console.WriteLine("c)\n");

               float[][] Array3 = new float[3][];
               Array3[0] = new float[2];
               Array3[1] = new float[3];
               Array3[2] = new float[4];
               Console.WriteLine($"Введите элементы ступенчатого массива: ");
               int a13 = 1, j13=0;
               for(int i13=0;i13<3;i13++)
               {
                   Console.WriteLine($"Строка {a13}: ");
                   foreach(int element in Array3[i13])
                   {
                       Array3[i13][j13] = Convert.ToInt32(Console.ReadLine());
                       j13++;               
                   }
                   a13++;
                   j13 = 0;
               }
               j13 = 0;
               Console.WriteLine($"Ступенчатый массив: ");
               for (int i13 = 0; i13 < 3; i13++)
               {

                   foreach (int element in Array3[i13])
                   {
                       Console.Write($"{Array3[i13][j13]} "); 
                       j13++;
                   }
                   Console.WriteLine();
                   a13++;
                   j13 = 0;
               }

               Console.WriteLine();

               //d) "НЕЯВНО ТИПИЗИРОВАННЫЕ ПЕРЕМЕННЫЕ ДЛЯ ХРАНЕНИЯ МАССИВА И СТРОКИ"

               Console.WriteLine("d)\n");

               var a14 = new[] { "string1", "string2", "string3" };
               var b14 = "string4";

   //4 КОРТЕЖИ

               Console.WriteLine("4)\n");

               //a) ЗАДАТЬ ИЗ ЭЛ-В ОПР-Х ТИПОВ

               Console.WriteLine("a)\n");
            
               var Weird = (10, "String1", 'a', "String2", 5e15);

            //b) ВЫВОД РАЗНЫМИ СПОСОБАМИ

            Console.WriteLine("b)\n");

            Console.WriteLine($"Все элементы кортежа: {Weird.Item1}, {Weird.Item2}, {Weird.Item3}, {Weird.Item4}, {Weird.Item5}");
            Console.WriteLine($"2-й и 3-й элементы кортежа: { Weird.Item2}, { Weird.Item3}\n");

            //c) РАСПАКОВКА РАЗНЫМИ СПОСОБАМИ

            Console.WriteLine("c)\n");

            var a15 = Weird.Item1;
            Console.WriteLine($"Распакованный первый элемент: {a15}\n");

            //d) СРАВНЕНИЕ КОРТЕЖЕЙ

            Console.WriteLine("d)\n");

            var firstWeird = (1, 4);
            var secondWeird = (1, 4);
            int a16 = firstWeird.CompareTo(secondWeird);
            Console.WriteLine($"Сравнение двух кортежей (0 - равны, -1 - не равны): {a16}\n");

//5) ФУНКЦИИ
    
            //a) СОЗДАТЬ И ВЫЗВАТЬ ЛОКАЛЬНУЮ ФУЕКЦИЮ

            Console.WriteLine("5)\n");

            Console.WriteLine("Введите размер массива: ");
            int length16 = Convert.ToInt32(Console.ReadLine()), counter16 = 1;
            int[] Array5 = new int[length16];
            for (int i1 = 0; i1 < length16; i1++)
            {
                Console.WriteLine($"Элемент {counter16}: ");
                Array5[i1] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите строку: ");
            string a16 = Console.ReadLine();

            var Weird16 = Func(Array5, a16, length16);

            static (int,int,char) Func(int[] A, string s16, int length16)
            {
                int min = A[0], max = min, sum = 0;
                for (int i16 = 0; i16 < length16; i16++)
                {
                    if (A[i16] > max)
                        max = A[i16];
                    if (A[i16] < min)
                        min = A[i16];
                    sum += A[i16];
                }
                char a16 = s16[0];
                var temp = (max,min,a16);
                return temp;
            }

            Console.WriteLine($"Максимальный элемент массива: {Weird16.Item1}\nМинимальный элемент массива: {Weird16.Item2}\nПервый символ строки: {Weird16.Item3}");

            Console.WriteLine();*/

            //6) checked/unchecked

            Console.WriteLine("6)\n");

            static void Func1()
            {
                checked
                {
                    int a17 = 2147483647;
                    Console.WriteLine($"Значение переменной в блоке checked: {a17}");
                }
            }

            static void Func2()
            {
                unchecked
                {
                    int b17 = 2147483647;
                    Console.WriteLine($"Значение переменной в блоке unchecked: {b17}");
                }
            }

            Func1();
            Func2();

        }
    }
}
