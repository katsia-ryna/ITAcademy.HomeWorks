using System;
using System.Drawing;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите один из символ W, S, A, D");
            char ch;
            ch =(char) Console.Read();
            if (ch == 'w')
            {
                Console.WriteLine("Переместить фигуру вверх");
            }
            else if(ch == 's')
            {
                Console.WriteLine("Переместить фигуру вниз");
            }
            else if(ch == 'a')
            {
                Console.WriteLine("Переместить фигуру влево");
            }
            else if (ch == 'd')
            {
                Console.WriteLine("Переместить фигуру вправо");
            }
            else
            {
                Console.WriteLine("Перемещение не происходит");
            }
            Console.ReadKey();
        }
    }
}
