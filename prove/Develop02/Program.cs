using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");
        Journal theJournal = new Journal();
        PromoptGenerator randomPrompt = new PromoptGenerator();
        
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write ("What would you like to do? ");
        
        string userInput = Console.ReadLine();



        while (userInput != "5")
        {
            switch (userInput)
            {
                case "1":
                    string prompt = randomPrompt.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    string userEntry = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");

                    Entry entry = new Entry(date, prompt, userEntry);
                    theJournal.AddNew(entry);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("Enter the filename to save the journal: ");
                    string saveFilename = Console.ReadLine();
                    theJournal.SaveToFile(saveFilename);
                    break;

                case "4":
                    Console.Write("Enter the filename to load the journal: ");
                    string loadFilename = Console.ReadLine();
                    theJournal.LoadFromFile(loadFilename);
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }
        }

        Console.WriteLine("Thank you for trying our Program. See you next time!");

    }
}