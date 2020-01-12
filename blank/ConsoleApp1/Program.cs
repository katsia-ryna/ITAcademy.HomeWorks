using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StringEqualitySpecifyingCompareRules();
            Console.ReadLine();
        }
        private static void StringEqualitySpecifyingCompareRules()
        {
            Console.WriteLine("String equality:");
            string s1 = "Hello";
            string s2 = "HELLO";
            Console.WriteLine("s1={0}", s1);
            Console.WriteLine("s2={0}", s2);
            Console.WriteLine();
            //проверка
            Console.WriteLine("Default rules: s1 = {0}, s2 = {1}s1.Equals(s2):{2}", s1, s2, s1.Equals(s2));
            Console.ReadLine();
        }
    }
}
