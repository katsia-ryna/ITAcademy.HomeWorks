using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Circle:GeometryFigures
    {
        private byte _radius;
        private string _name;
        public byte FigureCircle 
        {
            get { return _radius; }
        }
        public string CircleName { get { return _name; } }
        public Circle(string name, byte radius)
        {
            _name = name;
            _radius = radius;
        }
        public override double FigureArea()
        {
            return pi * _radius * _radius;
        }
    }
}
