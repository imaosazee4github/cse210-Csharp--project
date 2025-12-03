using System;
using System.Collections.Generic;


public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "List things that make you happy.",
        "List people who inspire you.",
        "List your personnal strenghts."
    };

    public ListingActivity():base("Listing Activity", "This activity helps you think of positive things in your life."){ }

    //Run method for the listing activity

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        Console.WriteLine("Prompt:");
        Console.WriteLine($"---{_prompts[rand.Next(_prompts.Count)]} ---");

        Console.WriteLine("You will begin in:");
        ShowCountDown(5);
        Console.WriteLine();

        int _durationSeconds = GetDuration();
        int elapsed = 0;
        int count = 0;

        //user lists items for the entire duration
        while (elapsed < _durationSeconds)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
            elapsed += 2;
        }

        Console.WriteLine($"You listed (count) items!");

        EndActivity();
    }
}