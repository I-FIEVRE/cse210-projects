using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);
        Fraction f4 = new Fraction(1,3);
        
        /*Console.WriteLine(f1.GetTop());
        Console.WriteLine(f1.GetBottom());
        Console.WriteLine(f2.GetTop());
        Console.WriteLine(f2.GetBottom());
        Console.WriteLine(f3.GetTop());
        Console.WriteLine(f3.GetBottom());*/

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

    }
}