using System;

public class ListingActivity : Activity
{
    List<string> _prompts;
    public ListingActivity(string name, string description, List<string> prompts) : base(name, description)
    {
        _prompts = prompts;
    }

    public string ShowRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        return randomPrompt;
    }

    public List<string> CollectItems(int duration)
    {
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        return items;
    }

    public void DisplayResults(int itemCount)
    {
        Console.WriteLine($"You listed {itemCount} items.");
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        SetDuration();
        int timeDuration = GetDuration();
        GetReady();
        string randomPrompt = ShowRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(randomPrompt);
        Console.WriteLine("You may begin in: ");
        CountDowntimer();
        List<string> items = CollectItems(timeDuration);
        DisplayResults(items.Count);
        DisplayEndMessage();

    }
}