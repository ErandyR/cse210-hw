using System;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("Blue", 4);
        //string squareColor = square1.GetColor();
        //double squareArea = square1.GetArea();

        Rectangle rectangle1 = new Rectangle("Red", 4, 6);
        //string rectangleColor = rectangle1.GetColor();
        //double rectangleArea = rectangle1.GetArea();

        Circle circle1 = new Circle("Yellow", 5);
        //string circleColor = circle1.GetColor();
        //double circleArea = circle1.GetArea();

        //Console.WriteLine($"Color of Square: {squareColor}");
        //Console.WriteLine($"Area of Square: {squareArea.ToString()}");

        //Console.WriteLine($"Color of Rectangle: {rectangleColor}");
        //Console.WriteLine($"Area of the rectangle: {rectangleArea.ToString()}");

        //Console.WriteLine($"Color of the circle: {circleColor}");
        //Console.WriteLine($"Area of the circle: {circleArea.ToString("F2")}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square1);
        shapes.Add(rectangle1);
        shapes.Add(circle1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color of shape: {shape.GetColor()}");
            Console.WriteLine($"Area of shape: {shape.GetArea():F2}");
        }
    }
}