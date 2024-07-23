using System;

public class Running : Activity
{
    private float _distance; // in kilometers

    public Running(float length, string type, float distance) : base(length, type)
    {
        _distance = distance;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }

    public override float CalculateSpeed()
    {
        float length = GetLength() / 60;
        return _distance / length;
    }

    public override float CalculatePace()
    {
        float length = GetLength();
        return length / _distance;
    }

    public override void Summary()
    {
        string date = GetDate();
        string type = GetTypeOfActivity();
        float length = GetLength();
        float speed = CalculateSpeed();
        float pace = CalculatePace();

        Console.WriteLine($"{date} {type} ({length} min)- Distance {_distance} km, Speed {speed} k/h, Pace {pace} min per km");
    }
}