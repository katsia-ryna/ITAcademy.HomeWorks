using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class VisitorInformation
    {
        public const string nameAirport = "Minsk International Airport";
        string nameVisitor;
        string passportNumber;

        public void PrintVisitorInformation()
        {
            Console.WriteLine("Good day!");
            Console.WriteLine($"Welcome to {nameAirport}");
            Console.WriteLine("Introduce yourselves, please. (Full name):");
            nameVisitor = Console.ReadLine();
            Console.WriteLine("Enter the passport number");
            passportNumber = Console.ReadLine();
            Console.WriteLine($"{nameVisitor}, proceed to the check-in counters, please.");
        }
    }
}
