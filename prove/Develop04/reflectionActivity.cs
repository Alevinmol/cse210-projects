using System;
using Microsoft.VisualBasic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity(string name, string description, List<string> prompts, List<string> questions) : base(name, description)
    {
        _prompts = prompts;
        _questions = questions;

    }

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }

    public string ShowRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        return randomPrompt;
    }

    public string ShowRandomQuestion()
    {
        Random random = new Random();
        string randomQuestion = _questions[random.Next(_questions.Count)];
        return randomQuestion;
    }

    public void RunActivity()
    {
        DisplayStartMessage();

        SetDuration();

        int timeDuration = GetDuration();

        GetReady();

        string randomPrompt = "";
        string randomQuestion = "";

        randomPrompt = ShowRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(randomPrompt);
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.Read();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.WriteLine("You may begin in: ");
        CountDowntimer();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(timeDuration);

        while (DateTime.Now < endTime)
        {
            randomQuestion = ShowRandomQuestion();
            Console.WriteLine(randomQuestion);
            Spinner();
        }

        DisplayEndMessage();
    }
}