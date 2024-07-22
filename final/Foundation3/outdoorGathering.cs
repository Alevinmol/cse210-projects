using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string type, string weatherForecast) : base(title, description, date, time, address, type)
    {
        _weatherForecast = weatherForecast;
    }

    public void FullDetais()
    {
        string type = GetTypeOfEvent();
        Console.WriteLine(type);
        StandardDetails();
        Console.WriteLine($"The weather forecast for the event is: {_weatherForecast}.");
    }
}