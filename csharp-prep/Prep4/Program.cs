using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number;

        Console.WriteLine("Enter a list of numbers, type 0 to quit.");
        
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine()); // convert the number entered by the user into integer
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Sum
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Average
        double average = (float)sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Maximum number
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        // Smallest positive number
        int min = numbers[0];
        foreach (int num in numbers)
        {
            if (num > 0)
            {
                if (num < min)
                {
                    min = num;
                }
            }
        } 
        Console.WriteLine($"The smallest positive number is: {min}");

        // int? smallestPositive = numbers.Where(n => n > 0).Min();
        // if (smallestPositive.HasValue)
        // {
        //     Console.WriteLine($"The smallest positive number is: {smallestPositive.Value}");
        // }
        // else
        // {
        //     Console.WriteLine("There are no positive numbers in the list.");
        // }

        // Sort the list and display it
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}