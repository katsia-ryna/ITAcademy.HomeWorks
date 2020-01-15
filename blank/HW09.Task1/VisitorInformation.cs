using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class VisitorInformation
    {
        public const string NameAirport = "Minsk International Airport";
        string _nameVisitor;
        string _passportNumber;

        public string NameVisitor
        {
            get { return _nameVisitor; }
        }
        public string PassportNumber
        {
            get { return _passportNumber; }
        }
        public void PrintVisitorInformation()
        {
            Console.WriteLine("Good day!");
            Console.WriteLine($"Welcome to {NameAirport}");
            Console.WriteLine("Introduce yourselves, please. (Full name):");
            _nameVisitor = Console.ReadLine();
            Console.WriteLine("Enter the passport number");
            _passportNumber = Console.ReadLine();
            Console.WriteLine($"{_nameVisitor}, proceed to the check-in counters, please.");
        }   
    }
}
