using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Triangle:GeometryFigures
    {
        private byte _b, _h;
        
        public Triangle(string name, byte b, byte h) : base(name)
        {
            Name = name;
            _b = b;
            _h = h;
        }
        public override double FigureArea()
        {
            return 0.5 * _b * _h;
        }
    }
}
