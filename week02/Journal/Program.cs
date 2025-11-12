using System;
using System.Collections.Generic;




//Program Class

class Program
{
    static void Main(string[] args)
    {
        // Create a new Journal object to hold entries
       Journal journal = new Journal();

       // A list of prompts that encourage reflective journal writing
       List<string>prompts = new List<string>()
       {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?",
       };

       string myChoice = "";

       // A menu-driven program allowing user interaction until they choose to quit
       while (myChoice != "5")
       {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? ");
        myChoice = Console.ReadLine();

        if (myChoice == "1")
        {
         // Generate a random prompt to make journaling more engaging
            Random rand = new Random();
            string _promptText = prompts[rand.Next(prompts.Count)];

        
            Console.WriteLine(_promptText);
            Console.Write(">");
            string entryText = Console.ReadLine();

            // Additional feature: mood rating and it allows the user to reflect emotionally on their day activities
            Console.Write("Rate your mood today (1-10): ");
            int mood = int.Parse(Console.ReadLine());

            // Create a new entry with all user input
            Entry newEntry = new Entry();
            newEntry._date = DateTime.Now.ToShortDateString();
            newEntry._promptText = _promptText;
            newEntry._entryText = entryText;
            newEntry._mood = mood;
            
            // Add the entry to the journal and immediately display updates
            journal.AddEntry(newEntry);

            // Immediate feedback feature — shows new entry added
            Console.WriteLine("\nYour entry has been added. Here is your updated journal: \n");
            journal.DisplayAll();
        }
        else if (myChoice == "2")
        {
        // Display all journal entries
            journal.DisplayAll();
        }
        
        else if (myChoice == "3")
        {
           // Save entries to a file 
            Console.Write("What is the filename?");
            string file = Console.ReadLine();
            journal.SaveToFile(file);
        }
        else if (myChoice == "4")
        {
        // Load entries from a saved file
            Console.Write("What is the filename?");
            string file = Console.ReadLine();
            journal.LoadFromFile(file);
        }
       }
    }
}