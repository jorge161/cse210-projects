using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int average;
        int larguest = 0;
        int smallest;

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number == 0)
            {
                break;
            }
            numbers.Add(number);
        }


        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        foreach (int number in numbers)
        {
            average = sum / numbers.Count;
            Console.WriteLine($"The average is: {average}");
            break;
        }

        foreach (int number in numbers)
        {
            if (number > larguest)
            {
                larguest = number;
            }
        }
        Console.WriteLine($"The larguest number is: {larguest}");

        smallest = numbers[0];
        foreach (int number in numbers)
        {
            if (number < smallest)
            {
                smallest = number;
            }
        }
        Console.WriteLine($"The smallest number is: {smallest}");

        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}