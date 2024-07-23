using System;

class Program
{
    static void Main(string[] args)
    {
        Running running = new Running(60, "Running", 10);
        running.SetDate();
        Bicycles bicycles = new Bicycles(180, "Cycling", 20);
        bicycles.SetDate();
        Swimming swimming = new Swimming(30, "Swimming", 10);
        swimming.SetDate();

        List<Activity> activities = new List<Activity>
        {
            running,
            bicycles,
            swimming
        };

        foreach (Activity activity in activities)
        {
            activity.Summary();
            Console.WriteLine();
        }
    }
}