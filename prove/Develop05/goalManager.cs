using System;
using System.ComponentModel;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints = 0;

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void RecordEvent(string goalName)
    {
        Goal goal = _goals.Find(g => g._name == goalName);
        if (goal != null)
        {
            _totalPoints += goal.RecordEvent();
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    public void DisplayGoals()
    {
        foreach (Goal goal in _goals)
        {
            string description = goal.GetDescription();
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"- {goal.GetStatus()}  {goal._name} ({description}) ");
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Total Points: {_totalPoints}");
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (var goal in _goals)
            {
                bool isComplete = goal.GetIsComplete();
                int points = goal.GetPoints();
                string description = goal.GetDescription();
                string goalType = goal.GetType().Name;
                writer.WriteLine(goalType);
                writer.WriteLine(goal._name);
                writer.WriteLine(description);
                writer.WriteLine(points);
                writer.WriteLine(isComplete);

                if (goal is ChecklistGoal checklistGoal)
                {
                    int requiredCount = checklistGoal.GetRequiredCount();
                    int currentCount = checklistGoal.GetCurrentCount();
                    int bonusPoints = checklistGoal.GetBonusPoints();
                    writer.WriteLine(requiredCount);
                    writer.WriteLine(currentCount);
                    writer.WriteLine(bonusPoints);
                }
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                while (!reader.EndOfStream)
                {
                    string goalType = reader.ReadLine();
                    string name = reader.ReadLine();
                    string description = reader.ReadLine();
                    int points = int.Parse(reader.ReadLine());
                    bool isComplete = bool.Parse(reader.ReadLine());

                    Goal goal = null;
                    if (goalType == nameof(SimpleGoal))
                    {
                        goal = new SimpleGoal(name, description, points);
                    }
                    else if (goalType == nameof(EternalGoal))
                    {
                        goal = new EternalGoal(name, description, points);
                    }
                    else if ( goalType == nameof(ChecklistGoal))
                    {
                        int requiredCount = int.Parse(reader.ReadLine());
                        int currentCount = int.Parse(reader.ReadLine());
                        int bonusPoints = int.Parse(reader.ReadLine());
                        goal = new ChecklistGoal(name, description, points, requiredCount, bonusPoints)
                        {
                            _currentCount = currentCount
                        };
                    }

                    if (goal != null)
                    {
                        goal.SetIsComplete(isComplete);
                        _goals.Add(goal);
                    }
                }
            }
        }
    }

    public void CreateNewGoal()
    {
        Console.WriteLine("Select the type of goal to create:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        int choice = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the name of the goal: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter the description of the goal: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter the points for the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
            AddGoal(new SimpleGoal(name, description, points));
            break;
            case 2:
            AddGoal(new EternalGoal(name, description, points));
            break;
            case 3:
            Console.WriteLine("How many times does this goal need to be acomplished for a bonus? ");
            int requiredCount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the bonus points for completing the checklist goal: ");
            int bonusPoints = int.Parse(Console.ReadLine());

            AddGoal( new ChecklistGoal(name, description, points, requiredCount, bonusPoints));
            break;
            default:
            Console.WriteLine("Invalid choice.");
            break;
        }
    }
}