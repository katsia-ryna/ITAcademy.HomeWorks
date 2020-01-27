using System;

namespace Task.Neighbor
{
    class Program
    {
        static void Main(string[] args)
        {
            Neighbor neighbor = new Neighbor();
            //neighbor.Print();
            Console.WriteLine("Enter the flat number");
            int number = Convert.ToInt32(Console.ReadLine());
            var num1=neighbor.Print(number);
            PrintNeighbor(num1);

            Console.ReadLine();
        }
        static void PrintNeighbor(Neighbor neighbor)
        {
            Console.WriteLine($"{neighbor._phoneNumber}, {neighbor._fullName}");
        }
    }
}
