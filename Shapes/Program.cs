using System;

namespace OOP_AbstractDemo
{
    // Abstract class
    abstract class Shape
    {
        // Abstract method (no implementation in base class)
        public abstract double GetArea();
    }

    // Derived class: Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class: Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances
            Shape circle = new Circle(5); // Radius = 5
            Shape rectangle = new Rectangle(4, 6); // Width = 4, Height = 6

            // Display area
            Console.WriteLine("Circle Area: " + circle.GetArea());
            Console.WriteLine("Rectangle Area: " + rectangle.GetArea());

            // Keep console open
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}