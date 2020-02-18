using System;
using System.Collections.Generic;
using System.Text;

namespace AssemblyOne
{
    public class Employee
    {
        public const string CurrentCompany = "SkyWay";
        internal string postInternal;
        internal int numberInternal;
        public float salaryPublic;
        private float salaryPrivate;
        protected float salaryProtected;
        protected string nameProtected;
        protected internal int AgeProtectedInternal;
        private protected int AgePrivateProtected;

       public void PrintPublic()
        {
            Console.WriteLine("Должность сотрудника = " + postInternal + " \n Номер сотрудника = " + numberInternal +" \n Зарплата = " + salaryPublic);
        }
        private void PrintNamePrivate()
        {
            Console.WriteLine("Stuff name");
        }
        protected internal void PrintAgeProtectedInternal()
        {
            Console.WriteLine("Write Age");
        }
        protected void PrintProtected()
        {
            Console.WriteLine("Зарплата = " + salaryProtected);
        }
        private protected void PrintAgePrivateProtected()
        {
            Console.WriteLine(AgePrivateProtected);
        }
    }
}
