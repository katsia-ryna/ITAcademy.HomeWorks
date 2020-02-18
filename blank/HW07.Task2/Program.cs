using System;
using System.Linq;

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

            int minLength = array1[0].Length;
            int num2 = 0;
            for(int i=0; i < array1.Length; i++)
            {
                if (array1[i].Length < minLength)
                {
                    minLength = array1[i].Length;
                    num2 = i;
                }
            }
            Console.WriteLine(num2);

            string[] array3 = new string[array1.Length];
            for(int i=0; i < array1.Length; i++)
            {
                array3[i] = array1[i];
                if (i == num1)
                {
                    array3[i] = array1[i].Substring(maxLength);
                    array3[i] = array1[num2];
                    continue;
                }
                if (i == num2)
                {
                    array3[i] = array1[i].Substring(minLength);
                    array3[i] = array1[num1];
                }
            }
            string text2 = string.Join(" ", array3);
            Console.WriteLine(text2);

            int countLetter = text.Count(char.IsLetter);
            Console.WriteLine($"Количество букв: {countLetter}");
            int countPunctuation = text.Count(char.IsPunctuation);
            Console.WriteLine($" Количество знаков пунктуации: {countPunctuation}");

            string temp;
            for (int i = 0; i < array1.Length - 1; i++)
            {
                for (int j = i + 1; j < array1.Length; j++)
                {
                    if (array1[i].Length < array1[j].Length)
                    {
                        temp = array1[i];
                        array1[i] = array1[j];
                        array1[j] = temp;
                    }
                }
            }
            Console.WriteLine("Вывод отсортированного массива");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }
            Console.ReadKey();
        }
    }
}
