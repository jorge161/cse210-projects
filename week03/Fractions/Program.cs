using System;

class Program
{
    static void Main(string[] args)
    {
        FractionClass fraction1 = new FractionClass();
        Console.WriteLine($"The fraction is: {fraction1.GetFractionString()}");
        Console.WriteLine($"The numerator is: {fraction1.GetDecimalValue()}");

        FractionClass fraction2 = new FractionClass(5);
        Console.WriteLine($"The fraction is: {fraction2.GetFractionString()}");
        Console.WriteLine($"The decimal value is: {fraction2.GetDecimalValue()}");

        FractionClass fraction3 = new FractionClass(3, 4);
        Console.WriteLine($"The fraction is: {fraction3.GetFractionString()}");
        Console.WriteLine($"The decimal value is: {fraction3.GetDecimalValue()}");

        fraction3 = new FractionClass(1, 3);
        Console.WriteLine($"The fraction is: {fraction3.GetFractionString()}");
        Console.WriteLine($"The decimal value is: {fraction3.GetDecimalValue()}");

    }
}