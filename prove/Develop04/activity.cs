using System;

public class Activity
{
    private int _duration;
    private string _name;
    private string _description;

    public Activity(string name, string description)
    {
        _duration = 0;
        _description = description;
        _name = name;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session to last? ");
        string response = Console.ReadLine();
        int duration = int.Parse(response);
        _duration = duration;
    }

    public void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }

    public void DisplayEndMessage()
    {
        Console.WriteLine("Well done!");
        Spinner();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        Spinner();
    }

    public void CountDowntimer()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void Spinner()
    {
        List<string>animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(5);

        int j = 0;

        while (DateTime.Now < endTime)
        {
            string a = animationString[j]; 
            Console.Write(a);
            Thread.Sleep(500);
            Console.Write("\b \b");

            j++;

            if (j>= animationString.Count)
            {
                j = 0;
            }
        }
    }

    public void GetReady()
    {
        Console.WriteLine("Get ready...");
        Spinner();
    }

}