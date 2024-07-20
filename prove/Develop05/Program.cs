using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();

        string choice;
        do
        {
            Console.WriteLine();
            manager.DisplayScore();
            Console.WriteLine();
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. Record event");
            Console.WriteLine("3. Display goals");
            Console.WriteLine("4. Save goals");
            Console.WriteLine("5. Load goals");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Select a choice from the menu: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    manager.CreateNewGoal();
                    break;
                case "2":
                    Console.WriteLine("Enter the name of the goal to record: ");
                    string goalName = Console.ReadLine();
                    manager.RecordEvent(goalName);
                    break;
                case "3":
                    manager.DisplayGoals();
                    break;
                case "4":
                    Console.WriteLine("Enter the filename: ");
                    string filename = Console.ReadLine();
                    manager.SaveGoals(filename);
                    break;
                case "5":
                    Console.WriteLine("Enter the filename: ");
                    filename = Console.ReadLine();
                    manager.LoadGoals(filename);
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 7.");
                    break;
            }
        } while (choice != "6");
    }
}