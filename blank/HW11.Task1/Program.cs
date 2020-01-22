using System;

namespace HW11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            GeometryFigures[] shape = new GeometryFigures[3];
            shape[0] = new Circle("circle", 4);
            shape[1] = new Square("square", 8);
            shape[2] = new Triangle("triangle", 2, 3);
            for (byte i = 1; i <= 10; i++)
            {
                shape[0] = new Circle("circle"+i, i);
                shape[1] = new Square("square"+i, i);
                shape[2] = new Triangle("triangle"+i, i, i);

                PrintFigure(shape);
            }

            Console.ReadLine();
        }
        public static void PrintFigure(GeometryFigures[] shape)
        {
            foreach (var item in shape)
            {
                Console.WriteLine($"This is {item}. CLR Type is {item}. Square is {item.FigureArea()}.");
            }
        }
    }
}
