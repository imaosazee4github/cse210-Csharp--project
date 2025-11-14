using System;


class Fraction
{
    // Private attributes
    private int _top;
    private int _bottom;

    //Constructor: no parameters

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    //Constructor: whole number -> wholeNumber/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    //Constructor: top/bottom(guard against 0 denominator)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = (bottom == 0) ? 1 : bottom;

        if(bottom == 0)
        {
            Console.WriteLine("Warning: denominator cannot be 0. Set to 1 instead.");
        }
        
    }

    //Getter and setter for top
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    //Getter and setter for bottom
    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        if(bottom == 0)
        {
            Console.WriteLine("Warning: denominator cannot be 0. Denominator left unchanged.");
            return;
        }
        _bottom = bottom;
    }

    //Return "a/b"
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    //Returns decimal value as double
    public double GetDecimalValue()
    {
        return (double)_top/_bottom;
    }
}