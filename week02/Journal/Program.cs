using System;
using System.Collections.Generic;




//Program Class

class Program
{
    static void Main(string[] args)
    {
       Journal journal = new Journal();

       List<string>prompts = new List<string>()
       {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
         "If I had one thing I could do over today, what would it be?",
       };

       string myChoice = "";

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
            Random rand = new Random();
            string _promptText = prompts[rand.Next(prompts.Count)];

            Console.WriteLine(_promptText);
            Console.Write(">");
            string entryText = Console.ReadLine();

            Console.Write("Rate your mood today (1-10): ");
            int mood = int.Parse(Console.ReadLine());

            Entry newEntry = new Entry();
            newEntry._date = DateTime.Now.ToShortDateString();
            newEntry._promptText = _promptText;
            newEntry._entryText = entryText;
            newEntry._mood = mood;

            journal.AddEntry(newEntry);

            Console.WriteLine("\nYour entry has been added. Here is your updated journal: \n");
            journal.DisplayAll();
        }
        else if (myChoice == "2")
        {
            journal.DisplayAll();
        }

        else if (myChoice == "3")
        {
            Console.Write("What is the filename?");
            string file = Console.ReadLine();
            journal.SaveToFile(file);
        }
        else if (myChoice == "4")
        {
            Console.Write("What is the filename?");
            string file = Console.ReadLine();
            journal.LoadFromFile(file);
        }
       }
    }
}