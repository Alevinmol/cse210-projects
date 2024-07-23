using System;
using System.Collections.Generic;

public class Entry
{
    public List<string> _prompts = new List<string>();
    public List<string> _entries = new List<string>();
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    public override string ToString()
    {
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }
}