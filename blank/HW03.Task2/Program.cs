using System;

namespace HW03.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 17;
            Int32 num2 = -4;
            Console.WriteLine(num1.GetType().FullName);
            Console.WriteLine(num2.GetType().FullName);
            Console.ReadKey();

            byte num3 = 6;
            sbyte num4 = -4;
            SByte num5 = 12;
            Console.WriteLine(num3.GetType().FullName);
            Console.WriteLine(num4.GetType().FullName);
            Console.WriteLine(num5.GetType().FullName);
            Console.ReadKey();

            short num6 = 3;
            Int16 num7 = 1;
            Console.WriteLine(num6.GetType().FullName);
            Console.WriteLine(num7.GetType().FullName);
            Console.ReadKey();

            long num8 = 8899;
            Int64 num9 = 967;
            Console.WriteLine(num8.GetType().FullName);
            Console.WriteLine(num9.GetType().FullName);
            Console.ReadKey();

            ushort num10 = 447;
            UInt16 num12 = 89;
            Console.WriteLine(num10.GetType().FullName);
            Console.WriteLine(num12.GetType().FullName);
            Console.ReadKey();

            char num13 = '5';
            Char num14 = '6';
            Console.WriteLine(num13.GetType().FullName);
            Console.WriteLine(num14.GetType().FullName);
            Console.ReadKey();

            float num15 = 8.65f;
            Single num16 = -1.44f;
            Console.WriteLine(num15.GetType().FullName);
            Console.WriteLine(num16.GetType().FullName);
            Console.ReadKey();

            double num17 = 4.6;
            Double num18 = -2.66;
            Console.WriteLine(num17.GetType().FullName);
            Console.WriteLine(num18.GetType().FullName);
            Console.ReadKey();

            decimal num19 = 6673.8m;
            Decimal num20 = 0.9e6m;
            Console.WriteLine(num19.GetType().FullName);
            Console.WriteLine(num20.GetType().FullName);
            Console.ReadKey();

            object num21 = 999;
            Object num22 = -5;
            Console.WriteLine(num21.GetType().FullName);
            Console.WriteLine(num22.GetType().FullName);
            Console.ReadKey();

            string num23 = "uygi";
            String num24 = "7777";
            Console.WriteLine(num23.GetType().FullName);
            Console.WriteLine(num24.GetType().FullName);
            Console.ReadKey();
        }
    }
}
