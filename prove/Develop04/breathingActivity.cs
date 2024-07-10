using System;

public class BreathingActivity : Activity
{
    private string _startMessage;
    private string _endMessage;

    public BreathingActivity(string name, string description, string startMessage, string endMessage) : base (name, description)
    {
        _startMessage = startMessage; // breathe in...
        _endMessage = endMessage; // now breathe out...
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        SetDuration();

        int timeDuration = GetDuration();

        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(_startMessage);
            CountDowntimer();
            Console.WriteLine(_endMessage);
            CountDowntimer();
        }
        DisplayEndMessage();
    }
}