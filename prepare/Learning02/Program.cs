using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._jobTitle = "Software Engineer";
        job._company = "Apple";
        job._startYear = new DateOnly(2005, 3, 15);
        job._endYear = new DateOnly(2019, 11, 1);

        Job job2 = new Job();
        job2._jobTitle = "Software Engineer";
        job2._company = "Microsoft";
        job2._startYear = new DateOnly(2020, 1, 6);
        job2._endYear = new DateOnly(2016, 5, 1);

        Resume resume = new Resume();
        resume._name = "Kenner Hartman";

        resume._jobs.Add(job);
        resume._jobs.Add(job2);

        resume.Display();
    }
}