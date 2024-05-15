using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._companyName = "Microsoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2016;
        job1._endYear = 2017;

        Job job2 = new Job();
        job2._companyName = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = 2018;
        job2._endYear = 2019;

        // job1.DisplayJob();
        // job2.DisplayJob();

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        resume1._name = "Alejandro Vinay";

        resume1.DisplayResume();
    }
}