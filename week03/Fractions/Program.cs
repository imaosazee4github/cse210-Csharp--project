using System;

class Program
{
    static void Main(string[] args)
    {
        //(1)Default constructor
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        //(2)One-parameter constructor
        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

         //(3)Two-parameter constructor
         Fraction f3 = new Fraction(3,4);
         Console.WriteLine(f3.GetFractionString());
         Console.WriteLine(f3.GetDecimalValue());

         Fraction f4 = new Fraction(1, 3);
         Console.WriteLine(f4.GetFractionString());
         Console.WriteLine(f4.GetDecimalValue());

         //Demostrate getters and setters
         Fraction f5 = new Fraction(2, 5);
         Console.WriteLine(f5.GetFractionString());
         f5.SetTop(7);
         f5.SetBottom(8);
         Console.WriteLine(f5.GetFractionString());
         Console.WriteLine(f5.GetDecimalValue());
    }
}