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
            IShape obj;

            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Triangle");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("insert width");
                    double Width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height");
                    double Height = double.Parse(Console.ReadLine());

                    obj = new Rectangle(Width, Height);

                    Console.WriteLine("area: " + obj.area());

                    Console.WriteLine("circumference: " + obj.circumference());


                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "2":
                    Console.WriteLine("insert radie");
                    double Radie = double.Parse(Console.ReadLine());


                    obj = new Circle(Radie);

                    Console.WriteLine("area: " + obj.area());

                    Console.WriteLine("circumference: " + obj.circumference());


                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                case "3":
                    Console.WriteLine("insert width");
                    Width = double.Parse(Console.ReadLine());

                    Console.WriteLine("insert height");
                    Height = double.Parse(Console.ReadLine());

                    obj = new Rectangle(Width, Height);

                    Console.WriteLine("area: " + obj.area());

                    Console.WriteLine("circumference: " + obj.circumference());


                    Console.ReadKey();
                    Console.Clear();
                    Main(null);

                    break;

                 default:
                    Main(null);
                    break;
            }

            
            
        }
    }
}