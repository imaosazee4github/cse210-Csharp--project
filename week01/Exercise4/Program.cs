using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        for(;;)
        {
            Console.Write("Enter a number: ");
            string userNumber = Console.ReadLine();
            int number = int.Parse(userNumber); 

            if (number == 0)
            {
                break;  //Stop when user enters 0
            }

            numbers.Add(number);
        }

        //if no numbers entered
        if (numbers.Count == 0)
           {
            Console.WriteLine("No numbers were entered.");
            return;
           }
           //get the sum 
           int sum = 0;

           for (int i = 0; i < numbers.Count; i++)
                {
                    sum += numbers[i];
                }
            // get the average 
            double average = (double)sum/numbers.Count;

            //Find the Maximum number
            int max = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
               {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
               }

               // Find the Minimum positive number
               int smallestPositiveNumber = int.MaxValue;
               bool positiveNumber = false;

               for(int i = 0; i < numbers.Count; i++)
               {
                if (numbers[i] > 0 && numbers[i] < smallestPositiveNumber)
                {
                    smallestPositiveNumber = numbers[i];
                    positiveNumber = true;
                }
               }

               // sort the list

               numbers.Sort();

               //Display the results
        
        Console.WriteLine($"The summ is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        if (positiveNumber)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositiveNumber}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers entered.");
            }
            
            Console.WriteLine("The sorted list is:.");
            for(int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

    }
}