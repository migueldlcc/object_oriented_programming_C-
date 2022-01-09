using System;

namespace ShapeAreaCalculator
{
    // This abstract Shape class is provided for you.
    // Your job is to complete the code in each of the 
    // derived classes: Triangle, Rectangle, Square, and Circle
    public abstract class Shape
    {
        public string Name { get; set; }

        public int Sides { get; set; }

        public virtual double Height { get; set; }

        public virtual double Width { get; set; }

        public abstract double Area();
    }
}
