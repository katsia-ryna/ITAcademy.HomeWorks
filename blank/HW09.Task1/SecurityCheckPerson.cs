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
            Console.WriteLine("Have you any prohibited items?");
            _answer = Console.ReadLine();
            if (_answer=="no")
            {
                Console.WriteLine("Ok, Let's scan your bag");
            }
            else
            {
                Console.WriteLine("You have to undergo a search.");
            }
            Console.WriteLine("Proceed to the passport control, please.");
        }
    }
}
