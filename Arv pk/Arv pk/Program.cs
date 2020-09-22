using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Triangle");
            Console.WriteLine("3. Circle");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1";
                    Console.WriteLine("insert width");
                    double width = double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Ange en höjd");
            int height = int.Parse(Console.ReadLine());
            double radie = double.Parse(Console.ReadLine());

            Console.WriteLine("Ange en bredd");
            int width = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(height, width);
            Triangle triangle = new Triangle(height, width);
            Circle circle = new Circle(radie);


            Console.WriteLine("Rektangelns area: " + rectangle.area());
            Console.WriteLine("Rektangelns omkrets: " + rectangle.circumference());
            Console.WriteLine("");



            Console.WriteLine("Triangelns area: " + triangle.area());
            Console.WriteLine("Triangelns omkrets: " + triangle.circumference());
            Console.ReadLine();

            Console.WriteLine("Cirkelns area: " + circle.area());
            Console.WriteLine("Cirkelns omkrets: " + circle.circumference());
            Console.ReadLine();
        }
    }
}