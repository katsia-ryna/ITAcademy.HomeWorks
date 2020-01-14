using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee stuff = new Employee();
            stuff.postInternal = "Developer";
            stuff.numberInternal = 12;
            stuff.salaryPublic = 2100;
            stuff.PrintPublic();
            stuff.PrintAgeProtectedInternal();
            // stuff.salaryPrivate=1000; // невозможно вызвать переменную, тк модификатор Private
            //stuff.PrintNamePrivate(); // невозможно вызвать метод, тк модификатор Private
            Developer stuffNew = new Developer();
            stuffNew.numberInternal = 27;
            stuffNew.salaryPublic = 1300;
            stuffNew.postInternal = "secretary";
            stuffNew.PrintPublic();
            stuffNew.salary =1900;
            Console.ReadLine();
        }
    }
}
