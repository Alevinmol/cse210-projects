using System;

public class Word
{
    private string _words;

    public Word()
    {
        _words = "";
    }

    public Word(string word)
    {
        _words = word;
    }

    public void SetWord(string word)
    {
        _words = word;
    }

    public List<string> TurnTextIntoWords()
    {
        List<string> words = new List<string>(_words.Split(' '));
        return words;
    }

    public bool AllWordsAreHidden(List<string> words)
    {
        foreach (string word in words)
        {
            if (!string.IsNullOrEmpty(word))
            {
                return false;
            }
        }
        return true;
    }
}