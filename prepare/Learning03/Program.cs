using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        string fraction1String = fraction1.GetFractionString();
        double fraction1Value = fraction1.GetDecimalValue();
        Console.WriteLine(fraction1String);
        Console.WriteLine(fraction1Value);

        Fraction fraction2 = new Fraction(5);
        string fraction2String = fraction2.GetFractionString();
        double fraction2Value = fraction2.GetDecimalValue();
        Console.WriteLine(fraction2String);
        Console.WriteLine(fraction2Value);

        Fraction fraction3 = new Fraction(3,4);
        string fraction3String = fraction3.GetFractionString();
        double fraction3Value = fraction3.GetDecimalValue();
        Console.WriteLine(fraction3String);
        Console.WriteLine(fraction3Value);

        Fraction fraction4 = new Fraction(1,3);
        string fraction4String = fraction4.GetFractionString();
        double fraction4Value = fraction4.GetDecimalValue();
        Console.WriteLine(fraction4String);
        Console.WriteLine(fraction4Value);
    }
}