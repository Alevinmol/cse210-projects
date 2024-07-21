using System;

public class Reception : Event
{
    private string _rsvp;

    public Reception(string title, string description, string date, string time, string address, string type) : base(title, description, date, time, address, type)
    {}
}