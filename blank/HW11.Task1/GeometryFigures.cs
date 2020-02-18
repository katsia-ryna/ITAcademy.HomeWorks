using System;
using System.Collections.Generic;
using System.Text;

namespace HW11.Task1
{
    class GeometryFigures
    {
        protected const float pi = 3.14159f;
        public string Name { get; set;}
        public GeometryFigures(string name)
        {
            Name = name;
        }
        public virtual double FigureArea()
        {
            return 1;
        }
    }
}
