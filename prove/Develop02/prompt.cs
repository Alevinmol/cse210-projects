using System;
using System.Collections.Generic;

public class Prompt
{
    public List<string> _prompts = new List<string>(); 
    public string ShowRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];
        return randomPrompt;
    }
}