using System;
using System.Collections.Generic;
using System.Text;

namespace HW10.Task1
{
    class Ship
    {
        public int Draft;
        public int Crew;
        
        public Ship(int draft, int crew)
        {
            Draft = draft;
            Crew = crew;
        }
        public bool IsWorthIt()
        {
            Console.WriteLine($"{(Draft - 1.5*Crew) > 20}");
            return (Draft - Crew) > 20;
        }
    }
}
