using System;

namespace ShapeAreaCalculator
{
    public class Rectangle : Shape
    {
        // Use the Triangle class as a guide to implement
        // the Rectangle class.

        // 1. Create a Rectangle constructor method and set its
        // Name and Sides properties.

        public Rectangle()
        {
            Name = "Reactangle";
            Sides = 4;
        }

        // 2. The area of a rectangle is calculated as Height X Width.

        public override double Area()
        {
            return (Height * Width);
        }
    }
}
