using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Triangle:GeometryFigures
    {
        private byte _b, _h;
        private string _name;
        private string _type;
        public byte FigureTriangle1
        {
            get { return _b; }
            set
            {
                if (value > 1 & value < 10)
                {
                    _b = value;
                }
                else
                    Console.WriteLine("Enter a number from 1 to 10 ");
            }
        }

        public byte FigureTriangle2
        {
            get { return _h; }
            set
            {
                if (value > 1 & value < 10)
                {
                    _h = value;
                }
                else
                    Console.WriteLine("Enter a number from 1 to 10 ");
            }
        }
        public string TrianglName { get { return _name; } }
        public string TrianglType { get { return _type; } }
        public Triangle(string name, string type, byte b, byte h)
        {
            _name = name;
            _type = type;
            _b = b;
            _h = h;
        }
        public override void FigureArea()
        {
            base.FigureArea();
            Console.WriteLine($"{0.5 *_b * _h}");
        }
    }
}
