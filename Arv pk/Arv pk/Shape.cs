using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Shape
    {
        protected int width;
        protected int height;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public Shape(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public virtual double Area()
        {
            return 0;
        }

        public virtual double Circumferance()
        {
            return 0;
        }
    }
}