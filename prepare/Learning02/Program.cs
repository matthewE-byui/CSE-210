using System;
using System.Collections.Generic;

class Job
{
    // Properties
    public string Company { get; set; }
    public string JobTitle { get; set; }
    public int StartYear { get; set; }
    public int EndYear { get; set; }

    // Method to display job information
    public void Display()
    {
        Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}

class Resume
{
    // Properties
    public string Name { get; set; }
    public List<Job> Jobs { get; set; } = new List<Job>();

    // Method to display resume
    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in Jobs)
        {
            job.Display();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create jobs
        Job job1 = new Job
        {
            Company = "Microsoft",
            JobTitle = "Software Engineer",
            StartYear = 2019,
            EndYear = 2022
        };

        Job job2 = new Job
        {
            Company = "Google",
            JobTitle = "Senior Developer",
            StartYear = 2022,
            EndYear = 2025
        };

        // Create resume
        Resume myResume = new Resume
        {
            Name = "Matthew Edgar"
        };

        // Add jobs to resume
        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        // Display resume
        myResume.Display();
    }
}
