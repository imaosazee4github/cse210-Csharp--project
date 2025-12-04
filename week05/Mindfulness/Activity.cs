using System;
using System.Collections.Generic;
using System.Threading;

public class  Activity
{
    //Principles: Encapsulation => Shared member variables
    protected string _activityName; //protected so that derived classes can read.
    protected string _description;  //Description shown to user
    private int _durationSeconds; // duration in sec.

    //......Constructor..........
    //sets the name and description for each activity

    public Activity(string name, string description)
    {
        _activityName = name;
        _description = description;
    }

    //-----set duration ------
    //Prompts the user and stores the chosen duration
    protected void SetDuration()
    {
        while (true)
        {
            Console.Write("Enter duration (in seconds): ");
            string input = Console.ReadLine();

            int value;
            bool isValid = int.TryParse(input, out value);

            if(isValid && value > 0)
            {
                _durationSeconds = value;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a whole number greater than 0 (e.g., 5, 10, 30).");
            }
        }
    }

    //-------Get duration ------
    //Allows derived classes to use duration

    public int GetDuration()
    {
        return _durationSeconds;
    }

    //-------Start Activity -----
    //Displays intro message and pauses before beginning
    public void StartActivity()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}!");
        Console.WriteLine();
        SetDuration();
        Console.WriteLine("Get ready...");
        ShowSpinner();
    }

    //-----End Activity -----
    //Displays closing message after each activity
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine($"Great job! You completed {_durationSeconds} seconds of {_activityName}.");
        ShowSpinner();
        Console.Clear();
    }

    //----Show spinner ----
    //simple animation using backspaces
    public void ShowSpinner()
    {
        for(int i = 0; i < 8; i++)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");

            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }

    //Show Countdown ------
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}