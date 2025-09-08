using System;
using System.Formats.Asn1;

class Program
{


    static void Main(string[] args)
    {
        string fullName;
        int userNumber;        
        DisplayMessage();
        fullName = Name();
        userNumber = number();         

        Console.WriteLine($"Hello {fullName}, the square of your number is {square(userNumber)}");
    }


    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string Name()
    {
        string userName;
        Console.Write("Please enter your name: ");
        userName = Console.ReadLine();
        return userName;
    }

    static int number()
    {
        int userNumber;
        Console.Write("Please enter your name: ");
        string input = Console.ReadLine();
        userNumber = int.Parse(input);

        return userNumber;
    }
    

    static int square(int num)
    {  int sq = num * num;

        return sq;
    } 

}

 