using System;
using ShapeAreaCalculator;

namespace ShapeCalculator
{
    class Program
    {
        // The Program class is provided for you.
        // Once the other classes are complete you can
        // run the program to test your code.
        static void Main()
        {
            Shape[] shapes = new Shape[4];

            shapes[0] = new Circle { Radius = 10 };
            shapes[1] = new Square { Height = 10 };
            shapes[2] = new Triangle { Height = 10, Width = 6 };
            shapes[3] = new Rectangle { Height = 10, Width = 100 };

            foreach (Shape shape in shapes)
            {
                try
                {
                    Console.WriteLine($"The { shape.Name }'s area is { shape.Area().ToString() }\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                
            }

            Console.WriteLine("Press any key to quit.");
            Console.ReadLine();
        }
    }
}
