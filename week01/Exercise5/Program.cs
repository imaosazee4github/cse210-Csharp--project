using System;

class Program
{
    static void Main(string[] args)
    {
        //Welcome program message
        DisplayWelcome();

        //get user information
        string name = PromptUserName();
        int number = PromptUserNumber();

        //Calculat the number square
        int squaredNumber = SquareNumber(number);

        //display the result
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your number: ");
        string userNumber = Console.ReadLine();
        int number = int.Parse(userNumber);
        return number;
    
    }

    static int SquareNumber(int number)
    {
        return number * number;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}