using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Triangle : Shape
    {
        public Triangle(int height, int width) : base(height, width) { }
        public override double Area()
        {
            double triArea = (width * height) / 2;
            return triArea;
        }
        public override double Circumferance()
        {
            double triCircumferance = height + width + (Math.Sqrt(width * width + height * height));
            return triCircumferance;
        }
    }
}