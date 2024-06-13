using System;
using System.Collections.Generic;

public class Scripture
{
    private string _reference;
    private string _text;

    public Scripture()
    {
        _reference = "";
        _text = "";
    }

    public Scripture(string reference)
    {
        _reference = reference;
    }

    public Scripture(string reference, string text)
    {
        _reference = reference;
        _text = text;
    }

    public void SetReference(string reference)
    {
        _reference = reference;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public List<string> HideWords(List<string> words, Random random)  // I made an effort here to make it so only new words get hidden.
    {
        int wordsToHide = Math.Min(1, words.Count);

        for (int i =0; i < wordsToHide; i++)
        {
            int index;                                        
            do
            {
                index = random.Next(words.Count);
            } while (string.IsNullOrEmpty(words[index]));

            words[index] ="";
        }
        return words;
    }

    public void DisplayText(string reference, List<string> words)
    {
        Console.WriteLine(reference);

        foreach (string word in words)
        {
            if (string.IsNullOrEmpty(word))
            {
                Console.WriteLine("______");
            }
            else
            {
                Console.Write(word + " ");
            }
        }
        Console.WriteLine();
    }
}