using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}
    public override string GetStatus()
    {
        return "[ ]";
    }

    public override int RecordEvent()
    {
        return GetPoints();
    }
}