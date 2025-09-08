using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentaje?");
        string grade = Console.ReadLine();
        int gradeInt = int.Parse(grade);

        Console.Write("Your grade is ");
        
        if (gradeInt >= 90)
            {
            if (gradeInt <= 93)
            {
                Console.WriteLine("A-");
            }
            else
            {
                Console.WriteLine("A");
            }           
         }

        else if (gradeInt >= 80)
        {
            if (gradeInt <= 83)
            {
                Console.WriteLine("B-");
            }
            else if (gradeInt >= 87)
            {
                Console.WriteLine("B+");
            }
            else
            {
                Console.WriteLine("B");
            }
             
        }

        else if (gradeInt >= 70)
        {   
            if (gradeInt <= 73)
            {
                Console.WriteLine("C-");
            }
            else if (gradeInt >= 77)
            {
                Console.WriteLine("C+");
            }
            else
            {
                Console.WriteLine("C");
            }
            
        }
        else if (gradeInt >= 60)
        {
            if (gradeInt <= 63)
            {
                Console.WriteLine("D-");
            }
            else if (gradeInt >= 67)
            {
                Console.WriteLine("D+");
            }
            else
            {
                Console.WriteLine("D");
            }
        }
        else
        {
            Console.WriteLine("F");
        }


    }
}