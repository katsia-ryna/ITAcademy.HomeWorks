using System;
using System.Reflection;

namespace HW11.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger.InitLogger();
            Logger.Log.Info(string.Concat("START_PROGRAMM:NAME " + Assembly.GetExecutingAssembly().GetName().Name + ", NAMESPACE " + Assembly.GetExecutingAssembly().EntryPoint.DeclaringType.Namespace));
            GeometryFigures[] shape = new GeometryFigures[3];
            
            for (byte i = 1; i <= 10; i++)
            {
                shape[0] = new Circle("circle"+i, i);
                shape[1] = new Square("square"+i, i);
                shape[2] = new Triangle("triangle"+i, i, i);

                Console.WriteLine();
                PrintFigure(shape);
            }
            
            Console.ReadLine();
            Logger.Log.Info("PROGRAMM_COMPLETED_SUCCESSFULLY");
        }
        public static void PrintFigure(GeometryFigures[] shape)
        {
            foreach (GeometryFigures item in shape)
            {
                Console.WriteLine($"This is {item.Name}. CLR Type is {item}. Square is {item.FigureArea()}.");
            }
        }

    }
}
