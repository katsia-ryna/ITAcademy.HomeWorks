using System;

namespace HW07.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($" Enter the poem with ';'");
            string words = (string)Console.ReadLine();
            words = words.Replace("o", "a");
            words = words.Replace("O", "A");
            string[] split = words.Split(new char[] { ';' });
            for(int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(split[i]);
            }
            Console.ReadKey();
        }
    }
}
