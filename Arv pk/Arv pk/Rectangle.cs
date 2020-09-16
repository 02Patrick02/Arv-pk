using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Rectangle : Shape
    {
        public Rectangle(int height, int width) : base(height, width) { }
        public override double Area()
        {
            int recArea = height * width;
            return recArea;
        }
        public override double Circumferance()
        {
            int recCircumferance = height * 2 + width * 2;
            return recCircumferance;
        }

    }
}