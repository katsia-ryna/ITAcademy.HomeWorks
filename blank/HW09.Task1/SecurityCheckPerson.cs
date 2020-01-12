using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class SecurityCheckPerson
    {
        string _answer;
        public void VisitorSecurityCheck()
        {
            Console.WriteLine("Please show me your hand baggage.");
            Console.WriteLine("Have you");
            if (_answer=="no")
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
            }
            Console.WriteLine("Proceed to the passport control, please.");
        }
    }
}
