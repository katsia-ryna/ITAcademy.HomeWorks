using System;
using System.Collections.Generic;
using System.Text;

namespace HW09.Task1
{
    class CheckIn
    {
        string _answer;
        string _luggage;
        public void VisitorCheckIn()
        {
            Console.WriteLine("Have you already registered online? (yes/no)");
            _answer = Console.ReadLine();
            if (_answer=="yes")
            {
                Console.WriteLine("Please show me your passport and ticket");
            }
            else
            {
                Console.WriteLine("Please show me your passport");
            }
            Console.WriteLine("Have you any luggage? (yes/no)");
            _luggage = Console.ReadLine();
            if (_luggage=="yes")
            {
                Console.WriteLine("You shoul weight your luggage and hand-in your luggage.");
                Console.WriteLine("Proceed to the security check, please.");
            }
            else
            {
                Console.WriteLine("Proceed to the security check, please.");
            }
        }
    }
}
