using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create job objects
        Job job1 = new Job();
        job1._jobTitle = "Software Developer";
        job1._company = "Smartbliss Tech. Solutions";
        job1._startYear = 2023;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Frontend Developer";
        job2._company = "Smartbliss Tech. Solutions";
        job2._startYear = 2024;
        job2._endYear = 2025;

        //Create resume object
        Resume resume = new Resume();
        resume._name = "Osazee Imadonmwinyi";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //Display full resume information.

        resume.DisplayResume();
    }
}

public class Job{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJobInfo()
    {
        Console.WriteLine($"{_jobTitle} at ({_company}) from {_startYear} tp {_endYear}");
    }
}

public class Resume{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobInfo();
        }
    }

}