using System;

namespace HW07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the sentence:");
            string text = (string)Console.ReadLine();
            string[] array1 = text.Split(new char[] {' '});
            foreach (string element in array1)
                Console.WriteLine(element);

            int maxLength=array1[0].Length;
            int num1 = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i].Length > maxLength)
                {
                    maxLength = array1[i].Length;
                    num1 = i;
                }
            }
            Console.WriteLine(num1);

            string[] array2 = new string[array1.Length];
            for(int i = 0; i < array1.Length; i++)
            {
                array2[i] = array1[i];
                if (i == num1)
                {
                    array2[i] = array1[i].Substring(maxLength);
                }
             }
            string text1 = string.Join(" ", array2);

            Console.WriteLine(text1);

            Console.ReadKey();
        }
    }
}
