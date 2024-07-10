using System;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "Breathing";
        string description1 = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

        BreathingActivity activity1 = new BreathingActivity(name1, description1, "Breathe in...","Now breathe out...");

        string name2 = "Reflection";
        string description2 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

        List<string> reflectionPrompts = new List<string>();
        List<string> reflectionQuestions = new List<string>();

        reflectionPrompts.Add("Think of a time when you stood up for someone else.");
        reflectionPrompts.Add("Think of a time when you did something really difficult.");
        reflectionPrompts.Add("Think of a time when you helped someone in need.");
        reflectionPrompts.Add("Think of a time when you did something truly selfless.");

        reflectionQuestions.Add("Why was this experience meaningful to you?");
        reflectionQuestions.Add("Have you ever done anything like this before?");
        reflectionQuestions.Add("How did you get started?");
        reflectionQuestions.Add("How did you feel when it was complete?");
        reflectionQuestions.Add("What made this time different than other times when you were not as successful?");
        reflectionQuestions.Add("What is your favorite thing about this experience?");
        reflectionQuestions.Add("What could you learn from this experience that applies to other situations?");
        reflectionQuestions.Add("What did you learn about yourself through this experience?");
        reflectionQuestions.Add("How can you keep this experience in mind in the future?");

        ReflectionActivity activity2 = new ReflectionActivity(name2, description2, reflectionPrompts, reflectionQuestions);

        string name3 = "Listing";
        string description3 = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        List<string> listingPrompts = new List<string>();

        listingPrompts.Add("Who are people that you appreciate?");
        listingPrompts.Add("What are personal strengths of yours?");
        listingPrompts.Add("Who are people that you have helped this week?");
        listingPrompts.Add("When have you felt the Holy Ghost this month?");
        listingPrompts.Add("Who are some of your personal heroes?");

        ListingActivity activity3 = new ListingActivity(name3, description3, listingPrompts);

        string choice;
        do
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    activity1.RunActivity();
                    break;
                case "2":
                    activity2.RunActivity();
                    break;
                case "3":
                    activity3.RunActivity();
                    break;
                case "4":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 4.");
                    break;
            }
        } while (choice != "4");

    }
}