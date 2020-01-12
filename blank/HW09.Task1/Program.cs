using System;

namespace HW09.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            VisitorInformation visitor = new VisitorInformation();
            visitor.PrintVisitorInformation();
            Console.WriteLine();

            CheckIn checkIn = new CheckIn();
            checkIn.VisitorCheckIn();
            Console.WriteLine();

            SecurityCheckPerson securityCheck = new SecurityCheckPerson();
            securityCheck.VisitorSecurityCheck();
            Console.WriteLine();

            PassportContolPerson passportContol = new PassportContolPerson();
            passportContol.VisitorsPassportControl();
            Console.ReadLine();
        }
    }
}
