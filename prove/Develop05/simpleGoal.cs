using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}
    public override string GetStatus()
    {
        bool status = GetIsComplete();
        if (status)
        {
            return "[X]";
        }
        return "[ ]";
    }

    public override int RecordEvent()
    {
        bool status = GetIsComplete();
        if (!status)
        {
            SetIsComplete(true);
            return GetPoints();
        }
        return 0;
    }
}