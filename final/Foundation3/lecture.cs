using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, string address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
}