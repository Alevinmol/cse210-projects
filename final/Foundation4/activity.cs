using System;
using System.ComponentModel;

public abstract class Activity
{
    string _type;
    string _date;
    float _lenght; // in minutes

    public Activity(float length, string type)
    {
        _lenght = length;
        _type = type;
    }

    public void SetDate()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
    }

    public string GetDate()
    {
        return _date;
    }

    public float GetLength()
    {
        return _lenght;
    }

    public string GetTypeOfActivity()
    {
        return _type;
    }

    public abstract float CalculateDistance();
    public abstract float CalculateSpeed();
    public abstract float CalculatePace();
    public abstract void Summary();
}