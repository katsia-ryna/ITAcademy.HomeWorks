using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class PassportContolPerson
    {
        string _country;
        string _purpose;
        public void VisitorsPassportControl(string person, string passport, string visa)
        {
            Console.WriteLine($"Please show me your {passport}");
            Console.WriteLine($"Identity check on {person}");
            Console.WriteLine("Where are you going?");
            _country = Console.ReadLine();
            Console.WriteLine($"Check {visa} of the country {_country}");
            Console.WriteLine("What is the purpose of your trip?");
            _purpose = Console.ReadLine();
            Console.WriteLine("All right, you can go.");
        }

        public void VisitorsPassportControl(string person, string passport)
        {
            Console.WriteLine($"Please show me your {passport}");
            Console.WriteLine($"Identity check on {person}");
            Console.WriteLine("Where are you going?");
            _country = Console.ReadLine();     
            Console.WriteLine("What is the purpose of your trip?");
            _purpose = Console.ReadLine();
            Console.WriteLine("All right, you can go.");
        }
    }
}
