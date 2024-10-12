using System;

namespace Assigment_Q2
{
    // Abstract base class Shape
    public abstract class Shape
    {
        // Private member variables for height and width
        private double shapeHeight;
        private double shapeWidth;

        // Constructor to initialize height and width
        protected Shape(double height, double width)
        {
            this.shapeHeight = height; // Use 'this' to distinguish from parameters
            this.shapeWidth = width;   // Use 'this' to distinguish from parameters
        }

        // Abstract method to calculate area
        public abstract double Area();

        // Property for height
        public double Height
        {
            get { return shapeHeight; }
            set { shapeHeight = value; }
        }

        // Property for width
        public double Width
        {
            get { return shapeWidth; }
            set { shapeWidth = value; }
        }
    }

    // Rectangle class that inherits from Shape
    class Rectangle : Shape
    {
        // Constructor for Rectangle
        public Rectangle(double rectWidth, double rectHeight) : base(rectHeight, rectWidth)
        {
        }

        // Override the Area method
        public override double Area()
        {
            return Height * Width; // Calculate area for rectangle
        }

        // Method to fill the rectangle
        public void FillRectangle()
        {
            Console.WriteLine("Filling color in Rectangle");
        }
    }

    // Triangle class that inherits from Shape
    class Triangle : Shape
    {
        // Constructor for Triangle
        public Triangle(double triBase, double triHeight) : base(triHeight, triBase)
        {
        }

        // Override the Area method
        public override double Area()
        {
            return 0.5 * Height * Width; // Calculate area for triangle
        }

        // Method to fill the triangle
        public void FillTriangle()
        {
            Console.WriteLine("Filling color in Triangle");
        }
    }

    // Static class for showing the area
    public static class ShowPolyClass
    {
        // Static method to show the area of the shape
        public static void ShowPoly(Shape shape)
        {
            Console.WriteLine($"Area: {shape.Area()}"); // Call the Area method and print the result
        }
    }

    // Main program class
    class Program
    {
        public static void Main(string[] args)
        {
            // Array of shapes
            Shape[] shapes = new Shape[6];
            shapes[0] = new Rectangle(5, 10);
            shapes[1] = new Rectangle(50, 100);
            shapes[2] = new Rectangle(2, 4);
            shapes[3] = new Triangle(4, 6);
            shapes[4] = new Triangle(6, 8);
            shapes[5] = new Triangle(8, 12);

            // Loop through each shape
            foreach (Shape shape in shapes)
            {
                ShowPolyClass.ShowPoly(shape); // Show the area of the shape

                // Check the type of shape and call the appropriate fill method
                if (shape is Rectangle rectangle)
                {
                    rectangle.FillRectangle(); // Call fill method for rectangle
                }
                else if (shape is Triangle triangle)
                {
                    triangle.FillTriangle(); // Call fill method for triangle
                }
            }
        }
    }
}
