using System;

public abstract class Goal
{
    public string _name;
    private string _description;
    private int _points;
    private bool _isComplete;

    public Goal (string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = false;
    }


    public string GetDescription()
    {
        return _description;
    }
    
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }

    public bool GetIsComplete()
    {
        return _isComplete;
    }

    public int GetPoints()
    {
        return _points;
    }

    public abstract int RecordEvent();
    public abstract  string GetStatus();

}