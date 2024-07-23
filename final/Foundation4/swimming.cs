using System;

public class Swimming : Activity
{
    private float _numberOfLaps;

    public Swimming(float length, string type, float numberOfLaps) : base(length, type)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override float CalculateDistance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override float CalculateSpeed()
    {
        float distance = CalculateDistance();
        float length = GetLength() / 60;
        return distance / length;
    }

    public override float CalculatePace()
    {
        float length = GetLength();
        float distance = CalculateDistance();
        return length * distance;
    }

    public override void Summary()
    {
        string date = GetDate();
        string type = GetTypeOfActivity();
        float length = GetLength();
        float distance = CalculateDistance();
        float speed = CalculateSpeed();
        float pace = CalculatePace();

        Console.WriteLine($"{date} {type} ({length} min)- Distance {distance} km, Speed {speed} k/h, Pace {pace} min per km");
    }
}