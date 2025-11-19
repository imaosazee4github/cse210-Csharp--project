using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
    
    List<(Reference, string)> library = new List<(Reference, string)>
    {
        (new Reference("John", 3, 16),
        "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish but have everlasting life."),
        (new Reference("Proverbs", 3,5,6),
        "Trust in the Lord with all thine heart and lean not unto own understanding. In all thy ways acknowledge him and he shall direct thy paths.")
    };
    Random random = new Random();

    //outer for loop, to restart the program for a new scripture
    for(;;)
    {
        (Reference, string) choice = library[random.Next(library.Count)];
        Scripture scripture = new Scripture(choice.Item1, choice.Item2);

        //Inner for loop, hide words one step at a time
        for(;;)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress<Enter>to continue words, or type 'quit' to exit.");

            string input = Console.ReadLine();
            if(input.ToLower() == "quit")
                return;
           scripture.HideRandomWords(2);
           if(scripture.IsCompletelyHidden())
           {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nAll words are now hidden!");
            break;
           }
        }

        Console.WriteLine("\nMemorize another scripture? (yes/no)");
        string again = Console.ReadLine().ToLower();

        if (again != "yes")
        return;
    }
}
}