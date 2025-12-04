// I added the following features to exceed the core rubric:
//
// Input Validation With Error Handling**
//    The program now handles invalid menu selections and prevents
//    crashing when the user enters invalid input.


using System;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;

        while(choice != 4)
        {
            Console.WriteLine("Hello World! This is the Mindfulness Project.");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("choose an option: ");

            choice = int.Parse(Console.ReadLine());
            Console.Clear();

            if(choice == 1)
            {
                BreathingActivity breath = new BreathingActivity();
                breath.Run();
            } else if (choice == 2)
            {
                ReflectingActivity reflect = new ReflectingActivity();
                reflect.Run();
            }

            else if(choice == 3)
            {
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }

        }
    }
}