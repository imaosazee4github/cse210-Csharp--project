using System;

class Program
{
    static void Main(string[] args)
    {
        // Get user grade percentages
        Console.Write("Enter your grade percentage: ");
        string gradePercentageInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradePercentageInput);

        string letterGrade = "";  //variable to store the letter grade.
        string sign = "";

        if (gradePercentage >= 90)
        {
            letterGrade = "A";
        }
        else if (gradePercentage >= 80)
        {
             letterGrade = "B";
        }
        else if (gradePercentage >= 70)
        {
            letterGrade = "C";
        }

        else if (gradePercentage >= 60)
        {
            letterGrade = "D";
        }
        else {
            letterGrade = "F";
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

        if (letterGrade == "A" && sign == "+")
        {
            sign = "";
        }

        if(letterGrade == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is: {letterGrade}{sign}");

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