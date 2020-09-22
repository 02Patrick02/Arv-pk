using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : IShape
    {
        double width, height;
        public Rectangle(double h, double w)
        {
            width = w;
            height = h;
        }
        public double area()
        {
            double Area = height * width;
            return Area;
        }
        public  double circumference()
        {
            double recCircumferance = height * 2 + width * 2;
            return recCircumferance;
        }

    }
}