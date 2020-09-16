using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ange en höjd");
            int height = int.Parse(Console.ReadLine());

            Console.WriteLine("Ange en bredd");
            int width = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(height, width);
            Triangle triangle = new Triangle(height, width);

            Console.WriteLine("Rektangelns area: " + rectangle.Area());
            Console.WriteLine("Rektangelns omkrets: " + rectangle.Circumferance());
            Console.WriteLine("");



            Console.WriteLine("Triangelns area: " + triangle.Area());
            Console.WriteLine("Triangelns omkrets: " + triangle.Circumferance());
            Console.ReadLine();
        }
    }
}