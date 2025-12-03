using System;

public class BreathingActivity : Activity
{
// Constructor inherits name + description setup
public BreathingActivity(): base("BreathingActivity",
"This activity will help you relax by guiding your breathing."){}
//Run method for breathing exercise

public void Run()
    {
        StartActivity();

        int _durationSeconds = GetDuration();
        int elapsed = 0;

        while (elapsed < _durationSeconds)
        {
            Console.WriteLine("Breath In ....");
            ShowCountDown(3);
            Console.WriteLine();

            Console.WriteLine("Breath out....");
            ShowCountDown(3);
            Console.WriteLine();

            elapsed += 6;
        }
        EndActivity();
    }
}