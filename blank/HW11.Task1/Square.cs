using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Square:GeometryFigures
    {
        private byte _a;
        private string _name;
        public byte FigureSquare
        {
            get { return _a; }
        }
        public string SquareName { get { return _name; } }
        public Square(string name, byte a)
        {
            _name = name;
            _a = a;
        }
        public override double FigureArea()
        {
            return _a * _a;
        }
    }
}
