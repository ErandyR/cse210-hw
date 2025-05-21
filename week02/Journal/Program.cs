using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        PromptGenerator myPrompt = new PromptGenerator();
        myPrompt._prompts.Add("Who was the most interesting person I interacted with today?");
        myPrompt._prompts.Add("What was the best part of my day?");
        myPrompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        myPrompt._prompts.Add("What was the strongest emotion I felt today?");
        myPrompt._prompts.Add("If I had one thing I could do over today, what would it be?");

        Entry myEntry = new Entry();


        Journal journal = new Journal();

        Console.WriteLine("Welcome to the journal Program");

        int index = 0;
        while (index != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write(">> ");
            index = int.Parse(Console.ReadLine());
            if (index == 1)
            {
                myEntry._propmtText = myPrompt.GetRandomPrompt();
                Console.WriteLine($"{myEntry._propmtText}");
                myEntry._entryText = Console.ReadLine();
                myEntry._date = DateTime.Now.ToString();
                journal.AddEntry(myEntry);
            }
            else if (index == 2)
            {
                journal.DisplayAll();
            }
            else if (index == 3)
            {
                Console.Write("Enter the filename to save to: ");
                journal._filename = Console.ReadLine();
                journal.SaveToFile(myEntry);
            }
            else if (index == 4)
            {
                Console.Write("Enter the filename to load from: ");
                journal._filename = Console.ReadLine();
                journal.LoadFromFile();
            }
        }

    }
}