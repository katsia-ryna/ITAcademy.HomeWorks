using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Square:GeometryFigures
    {
        private byte _a;
        
        public Square(string name, byte a) : base(name)
        {
            Name = name;
            _a = a;
        }
        public override double FigureArea()
        {
            return _a * _a;
        }
    }
}
