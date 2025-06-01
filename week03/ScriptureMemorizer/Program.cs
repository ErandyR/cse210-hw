using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Reference myReference = new Reference("Proverbs", 3, 5);
        string referenceText = myReference.GetDisplayText();
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding.";
        Scripture myScripture = new Scripture(myReference, scriptureText);

        Console.WriteLine($"{referenceText} {scriptureText}");


        Random random = new Random();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(referenceText);
            Console.WriteLine(myScripture.GetDisplayText());


            if (myScripture.IsCompletelyHidden())
            {
                Console.WriteLine("Words are hidden!");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                myScripture.HideRandomWords(1, random);
            }
            else if (input == "quit")
            {
                break;
            }
        }
    }
}