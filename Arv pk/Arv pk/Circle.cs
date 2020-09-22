using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Circle : IShape
    {
        private double radie;
        public Circle(double r)
        {
            radie = r;
        }

        public double area()
        {
            double area = Math.PI * radie * radie;
            return area;
        }
        public double circumference()
        {
            double Circumference = Math.PI * radie * 2;

            return Circumference;
        }
    }
}
