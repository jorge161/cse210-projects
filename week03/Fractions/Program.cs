using System;

class Program
{
    static void Main(string[] args)
    {
        FractionClass fraction = new FractionClass();
        Console.WriteLine($"The fraction is: {fraction.GetFractionString()}");
        Console.WriteLine($"The numerator is: {fraction.GetDecimalValue()}");

        fraction = new FractionClass(5);
        Console.WriteLine($"The fraction is: {fraction.GetFractionString()}");
        Console.WriteLine($"The decimal value is: {fraction.GetDecimalValue()}");

        fraction = new FractionClass(3, 4);
        Console.WriteLine($"The fraction is: {fraction.GetFractionString()}");
        Console.WriteLine($"The decimal value is: {fraction.GetDecimalValue()}");

        fraction = new FractionClass(1, 3);
        Console.WriteLine($"The fraction is: {fraction.GetFractionString()}");
        Console.WriteLine($"The decimal value is: {fraction.GetDecimalValue()}");

    }
}