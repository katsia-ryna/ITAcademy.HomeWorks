using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Square:GeometryFigures
    {
        private byte _a;
        private string _name;
        private string _type;
        public byte FigureSquare
        {
            get { return _a; }
            set
            {
                if (value > 1 & value < 10)
                {
                    _a = value;
                }
                else
                    Console.WriteLine("Enter a number from 1 to 10 ");
            }
        }
        public string SquareName { get { return _name; } }
        public string SquareType { get { return _type; } }
        public Square(string name, string type, byte a)
        {
            _name = name;
            _type = type;
            _a = a;
        }
        public override void FigureArea()
        {
            base.FigureArea();
            Console.WriteLine($"{_a*_a}");
        }
    }
}
