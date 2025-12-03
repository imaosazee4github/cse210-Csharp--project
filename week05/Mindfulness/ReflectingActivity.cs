using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>()
    {
        "Think of a time you showed courage.",
        "Think of a moment you felt proud of yourself.",
        "Think of a time you overcome a challenge."
    };

    private List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful?",
        "What did you learn from it?",
        "How can you apply this lesson today?",
        "How did this make you stronger?"
    };
    //Constructor
    public ReflectingActivity():base("Reflection Activity", "This activity helps you reflect on meaningful moments."){}

    //Run method for reflection activity

    public void Run()
    {
        StartActivity();

        Random rand = new Random();

        //Show prompt
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {_prompts[rand.Next(_prompts.Count)]} ---");
        Console.WriteLine("Press Enter when ready...");
        Console.ReadLine();

        int _durationSeconds = GetDuration();
        int elapsed = 0;

        //Ask deep questions
        while (elapsed < _durationSeconds)
        {
            string ques = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(ques);
            ShowSpinner();
            Console.WriteLine();

            elapsed += 4;
        }

        EndActivity();

    }
}