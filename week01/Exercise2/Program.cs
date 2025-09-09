using System;

class Program
{
    static void Main(string[] args)
    {
        string userGrade;
        Console.Write("What is your grade porcentaje?");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        if (gradeInt >= 90)
        {
            if (gradeInt <= 93)
            {
                userGrade = "A-";
            }
            else
            {
                userGrade = "A";
            }
        }

        else if (gradeInt >= 80)
        {
            if (gradeInt <= 83)
            {
                userGrade = "B-";
            }
            else if (gradeInt >= 87)
            {
                userGrade = "B+";
            }
            else
            {
                userGrade = "B";
            }

        }

        else if (gradeInt >= 70)
        {
            if (gradeInt <= 73)
            {
                userGrade = "C-";
            }
            else if (gradeInt >= 77)
            {
                userGrade = "C+";
            }
            else
            {
                userGrade = "C";
            }

        }
        else if (gradeInt >= 60)
        {
            if (gradeInt <= 63)
            {
                userGrade = "D-";
            }
            else if (gradeInt >= 67)
            {
                userGrade = "D+";
            }
            else
            {
                userGrade = "D";
            }
        }
        else
        {
            userGrade = "F";
        }

        Console.WriteLine($"Your grade is {userGrade} ");
        
        if (gradeInt >= 70)
        {
            Console.WriteLine("You passed the class. Congratulations!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time!");
        }


    }
}