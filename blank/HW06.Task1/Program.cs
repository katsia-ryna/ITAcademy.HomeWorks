using System;

namespace HW06.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1= new int[6];
            int i;
            Random rand = new Random() ;
            Console.WriteLine("Массив из случайных чисел:");
            for (i = 0; i < array1.Length; i++)
            {
                array1[i] = rand.Next(-100, 100);
                Console.WriteLine($" элемент массива: { array1[i]}");
            }

            int[] array2 = new int[6];
            for (i=0; i<array2.Length; i++)
            {
                Console.WriteLine($"введите элемент массива {i}й =", i+1);
                array2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine($"элемент массива {array2[i]}");
            }

            int[] array3 = new int[6];
            Console.WriteLine("Новый массив:");
            for(i = 0; i < array1.Length; i++)
            {
                array3[i] = array1[i] + array2[i];
                Console.WriteLine(array3[i]);
            }
            Console.ReadKey();
        }
    }
}
