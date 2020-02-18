using System;

namespace HW03.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //explicit conversion
            int num1 = 5;
            byte num2 = (byte)num1;
            long num3 = 11327;
            uint num4 = (uint)num3;
            float num5 = -2.37f;
            int num6 = (int)num5;
            Console.WriteLine(num2);
            Console.WriteLine(num4);
            Console.WriteLine(num6);
            Console.ReadKey();

            // implicit conversion
            byte num7 = 48;
            int num8 = num7;
            long num9 = -60274;
            double num10 = num9;
            uint num11 = 2027;
            ulong num12 = num11;
            Console.WriteLine(num8);
            Console.WriteLine(num10);
            Console.WriteLine(num12);
            Console.ReadKey();

            //boxing
            float val1 = 3.44f;
            object obj1 = val1;
            byte val2 = 13;
            object obj2 = val2;
            int val3 = 77;
            string num13 = val3.ToString();
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(num13);
            Console.ReadKey();

            //unboxing
            object obj4 = 7;
            int val4 = (int)obj4;
            object obj5 = 10;
            byte val5 = Convert.ToByte(obj5);
            string num14 = "477";
            int val6 = Convert.ToInt32(num14);
            Console.WriteLine(val4);
            Console.WriteLine(val5);
            Console.WriteLine(num14);
            Console.ReadKey();

        }
    }
}
