using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // Asking the grade percentage
        Console.Write("Enter your grade percentage: ");
        double gradePercentage = double.Parse(Console.ReadLine());

        // variables
        string letter;
        string sign;
        string Message;

        // Determine letter grade
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Sign
        int lastDigit = (int)gradePercentage % 10;
        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
            else
            {
                sign = "";
            }
        }
        else
        {
            sign = "";
        }

        // Determine pass or fail and set result message
        if (gradePercentage >= 70)
        {
            Message = "Congratulations! You passed the course.";
        }
        else
        {
            Message = "Don't worry, keep working hard for next time!";
        }

        // writeline the letter grade and result message
        Console.WriteLine($"Your grade is {letter}{sign}.");
        Console.WriteLine(Message);
        
    }
}