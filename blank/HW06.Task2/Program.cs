using System;

namespace HW06.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int i=0;
            for (i = 0; i < array1.Length-1; i++)
            {
                Console.WriteLine($"Введите {i}й элемент массива", i+1);
                array1[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($" Массив: {array1[i]}");
            }
            Console.WriteLine("введите номер елемента массива");
            int k = i = int.Parse(Console.ReadLine());
            int num1 = array1[i];
            Console.WriteLine("введите элемент массива");
            array1[k] = int.Parse(Console.ReadLine());

            for (i = 0; i <= k; i++)
            {
                Console.WriteLine($" Массив: {array1[i]}");
            }
            Console.WriteLine($" Массив: {num1}");
            for (i = k + 1; i < array1.Length-1; i++)
            {
                Console.WriteLine($" Массив: {array1[i]}");
            }
           /* for (i = 0; i < array1.Length; i++)
            {
                if (i < k)
                {
                    Console.WriteLine(array1[i]);
                }
                
                if (i == k)
                {
                    Console.WriteLine(array1[k]);
                    
                }
                if (i >= k)
                {
                    array1[i] = array1[i + 1];
                    Console.WriteLine(array1[i]);
                }
            }*/
            Console.ReadKey();
        }
    }
}
