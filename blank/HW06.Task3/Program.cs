using System;
using System.Diagnostics;

namespace HW06.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] array1 = new Int64[10];
            Random rand = new Random();
            int i;
            for(i=0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(-100, 100);
                Console.WriteLine($"{i}й элемент массива:{array1[i]}");
            }

            Console.WriteLine("Вывод обратного массива:");
            Stopwatch count=new Stopwatch();
            count.Start();
            for (i = array1.Length-1; i >= 0; i--)
            {
                Console.WriteLine(array1[i]);
            }
            count.Stop();
            long timeCount = count.ElapsedMilliseconds;
            Console.WriteLine($" Время выполнения обратного массива: {timeCount}");
            Console.ReadLine();

            count.Start(); 
            Array.Reverse(array1);
            Int64[] array2 = array1;
            Console.WriteLine("Вывод массива методом Reverse:");
            foreach(var element in array2)
            Console.WriteLine(element);
            count.Stop();
            timeCount = count.ElapsedMilliseconds;
            Console.WriteLine($"Время выполнения массива методом Reverse: {timeCount}");
            Console.ReadLine();
        }
    }
}
