using System;
using AssemblyOne;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee stuff1 = new Employee();
            stuff1.salaryPublic=3500;
            stuff1.PrintPublic();
            //stuff1.postInternal="Boss" // невозможно вызвать переменную, тк модификатор Internal
            //stuff1.PrintAgePrivateProtected() // невозможно вызвать переменную, тк модификатор Private Protected
            Developer stuff2 = new Developer();
            stuff2.salaryPublic = 1400;
            stuff2.PrintPublic();
            Console.ReadLine();
        }
    }
}
