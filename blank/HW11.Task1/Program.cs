using System;

namespace HW11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random rand = new Random();
            //int num1 = rand.Next(1, 10);
            //Console.WriteLine("Enter parametr:");

            GeometryFigures shape = new GeometryFigures();
            Circle circle = new Circle("figure-circle", "circle", 4);
            circle.FigureArea();

            Square square = new Square("figure-square", "square", 8);
            square.FigureArea();

            Triangle triangle = new Triangle("figure-triangle", "triangle", 2,3);
            triangle.FigureArea();

            Console.ReadLine();
        }
    }
}
