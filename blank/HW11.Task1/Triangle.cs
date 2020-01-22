using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Triangle:GeometryFigures
    {
        private byte _b, _h;
        private string _name;
        public byte FigureTriangle1
        {
            get { return _b; }
        }

        public byte FigureTriangle2
        {
            get { return _h; }
        }
        public string TrianglName { get { return _name; } }
        public Triangle(string name, byte b, byte h)
        {
            _name = name;
            _b = b;
            _h = h;
        }
        public override double FigureArea()
        {
            return 0.5 * _b * _h;
        }
    }
}
