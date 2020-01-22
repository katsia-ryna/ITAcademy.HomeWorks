using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Circle:GeometryFigures
    {
        private byte _radius;
       
        public Circle(string name, byte radius):base (name)
        {
            Name = name;
            _radius = radius;
        }
        public override double FigureArea()
        {
            return pi * _radius * _radius;
        }
    }
}
