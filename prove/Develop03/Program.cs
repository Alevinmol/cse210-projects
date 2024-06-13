using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Reference reference1 = new Reference("Proverbs", "3", "5-6");

        string memorizationReference = reference1.GetReference();

        Scripture scripture1 = new Scripture(memorizationReference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        string memorizationVerses = scripture1.GetText();

        Word word1 = new Word(memorizationVerses);

        List<string> words = word1.TurnTextIntoWords();
        Random random = new Random();

        while(true)
        {
            Console.Clear();
            scripture1.DisplayText(memorizationReference, words);

            Console.WriteLine("Press Enter to hide words or 'quit' to end the program");
            string input = Console.ReadLine().ToLower(); // if the user writes QUIT it still works

            if (input == "quit")
            {
                Console.WriteLine("ending the program");
                break;
            }

            words = scripture1.HideWords(words, random);

            if (word1.AllWordsAreHidden(words))
            {
                Console.Clear();
                scripture1.DisplayText(memorizationReference, words);
                Console.WriteLine("All words are hidden. Ending the program.");
                break;
            }
        }
    }
}