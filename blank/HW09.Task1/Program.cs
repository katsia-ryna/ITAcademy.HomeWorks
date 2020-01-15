using System;

namespace HW09.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorInformation visitor = new VisitorInformation();
            visitor.PrintVisitorInformation();
            Console.WriteLine($"{visitor.NameVisitor}"); 
            Console.WriteLine($"{visitor.PassportNumber}");
            
            CheckIn checkIn = new CheckIn();
            checkIn.VisitorCheckIn();
            Console.WriteLine("Enter weight of your laggage: ");
            sbyte laggage = sbyte.Parse(Console.ReadLine());
            checkIn.Laggage = laggage;
            Console.WriteLine();

            SecurityCheckPerson securityCheck = new SecurityCheckPerson("backpack", "tourism");
            securityCheck.VisitorSecurityCheck();
            Console.WriteLine();

            PassportContolPerson passportContol = new PassportContolPerson();
            Console.WriteLine("Does the passenger need a visa? (yes/no)");
            string answer = Console.ReadLine();
            if (answer=="yes")
            {
                passportContol.VisitorsPassportControl("passenger", "passport", "visa");
            }
            else
            {
                passportContol.VisitorsPassportControl("passenger", "passport");
            }
            Console.ReadLine();
        }
    }
}
