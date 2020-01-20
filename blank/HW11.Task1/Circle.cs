using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class Circle:GeometryFigures
    {
        private byte _radius;
        private string _name;
        private string _type;
        public byte FigureCircle 
        {
            get { return _radius; }
            set
            {
                if (value>1 & value<10)
                {
                    _radius = value;
                }  
                else
                    Console.WriteLine("Enter a number from 1 to 10 ");
            } 
        }
        public string CircleName { get { return _name; } }
        public string CircleType { get { return _type; } }
        public Circle(string name, string type, byte radius)
        {
            _name = name;
            _type = type;
            _radius = radius;
        }
        public override void FigureArea()
        {
            base.FigureArea();
            Console.WriteLine($"{pi*_radius*_radius}");
            //return pi * _radius * _radius;
        }
    }
}
