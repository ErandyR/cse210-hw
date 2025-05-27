using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        /*Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(6);
        Fraction f3 = new Fraction(6, 7);*/

        Fraction f = new Fraction(1, 3);
        //f.SetTopNumber(3);
        //f.SetBottomNumber(4);

        Console.WriteLine(f.GetFraction());
        Console.WriteLine(f.GetDecimalValue());
    }
}