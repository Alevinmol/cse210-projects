using System;
using System.Text.RegularExpressions;

public class ChecklistGoal : Goal
{
    private int _requiredCount;
    public int _currentCount;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, int requiredCount, int bonusPoints) : base(name, description, points)
    {
        _requiredCount = requiredCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

    public int GetRequiredCount()
    {
        return _requiredCount;
    }

    public int GetCurrentCount()
    {
        return _currentCount;
    }

    public void SetCurrentCount(int currentCount)
    {
        _currentCount = currentCount;
    }

    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public override string GetStatus()
    {
        bool status = GetIsComplete();
        if (status)
        {
            return "[X]";
        }
        return $"[ ] Completed {_currentCount}/{_requiredCount} times.";
    }

    public override int RecordEvent()
    {
        bool status = GetIsComplete();
        if (!status)
        {
            _currentCount++;
            if (_currentCount >= _requiredCount)
            {
                SetIsComplete(true);
                return GetPoints() + _bonusPoints;
            }
            return GetPoints();
        }
        return 0;
    }
}