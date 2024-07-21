using System;

public class OutdoorGathering : Event
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, string date, string time, string address, string type) : base(title, description, date, time, address, type)
    {}
}