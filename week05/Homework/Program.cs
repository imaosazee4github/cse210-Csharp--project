using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign1 = new Assignment("Osazee Imadonmwinyi", "Multiplication");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment math = new MathAssignment(
            "Word Problem",
            "Fractions",
            "7.3",
            "3-10, 20-21"
        );

        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
    }
}