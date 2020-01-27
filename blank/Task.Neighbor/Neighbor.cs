using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Task.Neighbor
{
    class Neighbor
    {
        public string _fullName;
        private int _flatNumber;
        public int _phoneNumber;

        private List<Neighbor> _floorNeighbors;
        public Neighbor()
        {
            _floorNeighbors = new List<Neighbor>()
            {
                new Neighbor()
                {
                    _fullName="Kie",
                    _flatNumber=44,
                    _phoneNumber=123567
                },
                new Neighbor()
                {
                    _fullName="Tom",
                    _flatNumber=45,
                    _phoneNumber=2412763
                },
                new Neighbor()
                {
                    _fullName="Molly",
                    _flatNumber=46,
                    _phoneNumber=78956241
                }
            };
        }

        public Neighbor Print(int num)
        {
            Console.WriteLine("Enter the flat number");
            int number = Convert.ToInt32(Console.ReadLine());

            /*if (_flatNumber==number)
            {
                //Console.WriteLine($"phone number = {_phoneNumber} /n name floor neighbor = {_fullName}");

            }*/
            return _floorNeighbors.FirstOrDefault(t => t._flatNumber == number);
        }

    }
}
