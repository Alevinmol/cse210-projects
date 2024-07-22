using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetais()
    {
        string type = GetTypeOfEvent();
        Console.WriteLine(type);
        StandardDetails();
        Console.WriteLine($"Speaker: {_speaker}\n Capacity: {_capacity}");
    }
}