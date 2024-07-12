using System;

class Program
{
    static void Main(string[] args)
    {
        Shape shape1 = new Square("blue",5);
        Shape shape2 = new Rectangle("green", 3, 8);
        Shape shape3 = new Circle("red", 7);

        List<Shape> shapes = new List<Shape>();

        shapes.Add(shape1);
        shapes.Add(shape2);
        shapes.Add(shape3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}