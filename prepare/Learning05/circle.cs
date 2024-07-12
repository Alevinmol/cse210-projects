using System;

public class Circle : Shape
{
    private double _pi = 3.1416;
    private double _radious;

    public Circle(string color, double radious) : base(color)
    {
        _radious = radious;
    }

    public override double GetArea()
    {
        return _pi * _radious * _radious;
    }
}