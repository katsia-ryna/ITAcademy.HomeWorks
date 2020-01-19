using System;

namespace HW10.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            //https://www.codewars.com/kata/53f0f358b9cb376eca001079
            /*Create a class Ball.
             Ball objects should accept one argument for "ball type" when instantiated.
             If no arguments are given, ball objects should instantiate with a "ball type" of "regular."*/

            Ball ball1 = new Ball();
            Console.WriteLine($"{ball1.ballType}");
            Ball ball2 = new Ball("super");
            Console.WriteLine($"{ball2.ballType}");
            Console.ReadLine();
        }
    }
}
