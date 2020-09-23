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

        }
    }
}
