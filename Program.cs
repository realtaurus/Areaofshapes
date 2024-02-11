using System;

class Program
{
    static void Main(string[] args)
    {
        // Circle
        Console.WriteLine("Enter the radius of the circle:");
        double radius = double.Parse(Console.ReadLine());
        double circleArea = CalculateCircleArea(radius);
        Console.WriteLine($"Area of the circle: {circleArea}");

        // Triangle
        Console.WriteLine("Enter the base length of the triangle:");
        double baseLength = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height of the triangle:");
        double height = double.Parse(Console.ReadLine());
        double triangleArea = CalculateTriangleArea(baseLength, height);
        Console.WriteLine($"Area of the triangle: {triangleArea}");

        // Rectangle
        Console.WriteLine("Enter the length of the rectangle:");
        double length = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the width of the rectangle:");
        double width = double.Parse(Console.ReadLine());
        double rectangleArea = CalculateRectangleArea(length, width);
        Console.WriteLine($"Area of the rectangle: {rectangleArea}");

        // Square
        Console.WriteLine("Enter the side length of the square:");
        double side = double.Parse(Console.ReadLine());
        double squareArea = CalculateSquareArea(side);
        Console.WriteLine($"Area of the square: {squareArea}");
    }

    // Circle Area Method
    static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Triangle Area Method
    static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    // Rectangle Area Method
    static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }

    // Square Area Method
    static double CalculateSquareArea(double side)
    {
        return side * side;
    }
}

