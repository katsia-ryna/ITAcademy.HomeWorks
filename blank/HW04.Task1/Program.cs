using System;
using System.Text;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {                
            char ch;
            for (int i = 90; i >= 65; i--)
            {
                ch = Convert.ToChar(i);
                Console.WriteLine(ch);
            }
            Console.ReadKey();
        }
    }
}
