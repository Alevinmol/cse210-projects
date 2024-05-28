using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal1 = new Journal();
        string choice;
        do
        {
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    WriteNewEntry(journal1);
                    break;
                case "2":
                    DisplayJournal(journal1);
                    break;
                case "3":
                    SaveJournalToFile(journal1);
                    break;
                case "4":
                    LoadJournalFromFile(journal1);
                    break;
                case "5":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 5.");
                    break;
            }
        } while (choice != "5");
        static void WriteNewEntry(Journal journal)
        {
            Prompt prompt1 = new Prompt();
            string firstPrompt = "Who was the most interesting person I interacted with today?";
            string secondPrompt = "What was the best part of my day?";
            string thirdPrompt = "How did I see the hand of the Lord in my life today?";
            string fourthPrompt = "What was the strongest emotion I felt today?";
            string fifthPrompt = "If I had one thing I could do over today, what would it be?";

            prompt1._prompts.Add(firstPrompt);
            prompt1._prompts.Add(secondPrompt);
            prompt1._prompts.Add(thirdPrompt);
            prompt1._prompts.Add(fourthPrompt);
            prompt1._prompts.Add(fifthPrompt);

            string randomPrompt = prompt1.ShowRandomPrompt();
            Console.WriteLine($"Prompt: {randomPrompt}");
            Console.Write("Response: ");
            string _response = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;
            string _date = theCurrentTime.ToShortDateString();

            journal.AddEntry(randomPrompt, _response, _date);
        }

        static void DisplayJournal(Journal journal)
        {
            journal.DisplayEntries();
        }

        static void SaveJournalToFile(Journal journal)
        {
            Console.Write("Enter the filenama to save the journal to: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
            Console.WriteLine("Journal saved.");
        }

        static void LoadJournalFromFile(Journal journal)
        {
            Console.Write("Enter the filename to load the journal from: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded.");
        }

    }
}