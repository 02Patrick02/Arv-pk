using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Triangle : IShape
    {
        double width, height;
        public Triangle(double h, double w)
        {
            height = h;
            width = w;
        }

        public double area()
        {
            double triArea = (width * height) / 2;
            return triArea;
        }
        public double circumference()
        {
            double triCircumferance = height + width + (Math.Sqrt(width * width + height * height));
            return triCircumferance;
        }
    }
}