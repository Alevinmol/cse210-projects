using System;

public class Bicycles : Activity
{
    private float _speed; // in k/h

    public Bicycles(int length, string type, float speed) : base(length, type)
    {
        _speed = speed;
    }

    public override float CalculateDistance()
    {
        float length = GetLength() / 60;
        return _speed * length;
    }

    public override float CalculateSpeed()
    {
        return _speed;
    }

    public override float CalculatePace()
    {
        float distance = CalculateDistance();
        float length = GetLength();
        return length / distance;
    }

    public override void Summary()
    {
        string date = GetDate();
        string type = GetTypeOfActivity();
        float length = GetLength();
        float distance = CalculateDistance();
        float pace = CalculatePace();

        Console.WriteLine($"{date} {type} ({length} min)- Distance {distance} km, Speed {_speed} k/h, Pace {pace} min per km");
    }
}