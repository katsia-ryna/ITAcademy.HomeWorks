using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class SecurityCheckPerson
    {
        string _answer;
        public string handBaggage;
        public string purpose;

        public SecurityCheckPerson(string handBag)
        {
            handBaggage = handBag;
        }

        public SecurityCheckPerson(string handBag, string purpose)
        {
            handBaggage = handBag;
            this.purpose = purpose;
        }
        public void VisitorSecurityCheck()
        {
            Console.WriteLine($"Please show me your {handBaggage}.");
            Console.WriteLine("Have you any prohibited items?");
            _answer = Console.ReadLine();
            if (_answer=="no")
            {
                Console.WriteLine($"Ok, Let's scan your {handBaggage}");
            }
            else
            {
                Console.WriteLine("You have to undergo a search.");
            }
            Console.WriteLine("What is the purpose of your trip?");
            Console.WriteLine($"{purpose}");
            Console.WriteLine("Proceed to the passport control, please.");
        }
    }
}
