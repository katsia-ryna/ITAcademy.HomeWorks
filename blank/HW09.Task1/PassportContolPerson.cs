using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class PassportContolPerson
    {
        string country;
        string purpose;
        public void VisitorsPassportControl(string person, string passport, string visa)
        {
            Console.WriteLine($"Please show me your {passport}");
            Console.WriteLine($"Identity check on {person}");
            Console.WriteLine("Where are you going?");
            country = Console.ReadLine();
            Console.WriteLine($"Check {visa} of the country {country}");
            Console.WriteLine("What is the purpose of your trip?");
            purpose = Console.ReadLine();
            Console.WriteLine("All right, you can go.");
        }
    }
}
