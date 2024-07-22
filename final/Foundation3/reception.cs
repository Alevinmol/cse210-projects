using System;

public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string type, string rsvpEmail) : base(title, description, date, time, address, type)
    {
        _rsvpEmail = rsvpEmail;
    }

    public void FullDetais()
    {
        string type = GetTypeOfEvent();
        Console.WriteLine(type);
        StandardDetails();
        Console.WriteLine($"RSVP to: {_rsvpEmail}");
    }
}