using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user grade percentages
        Console.Write("Enter your grade percentage: ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInput);

        string letter = "";  //variable to store the letter grade.
        string sign = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
             letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }

        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else {
            letter = "F";
        }


        int lastDigit = gradePercentage % 10; // Get the reminder (last digit)

        if(lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }

        //Handle spacial cases like removing the A+ or F+ or F-

        if (letter == "A" && sign == "+")
        {
            sign = "";
        }

        if(letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letter}{sign}");

//check if student passed at least 70%

if (gradePercentage >= 70)
{
    Console.WriteLine("Congratulations! you passed the class!");
}
else { 
    Console.WriteLine("Keep working hard! You will do better next time!");
}
    }
}