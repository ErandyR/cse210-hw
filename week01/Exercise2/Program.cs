using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please provide your grade percentage:");
        string percentage = Console.ReadLine();
        int classPercentage = int.Parse(percentage);
        
        string letter = "";

        if (classPercentage >= 90)
        {
            letter = "A";
        }
        else if (classPercentage >= 80)
        {
            letter = "B";
        }
        else if (classPercentage >= 70)
        {
            letter = "C";
        }
        else if (classPercentage >= 60)
        {
            letter = "D";
        }
        else if (classPercentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (classPercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course");
        }
        else
        {
            Console.WriteLine("Unfortunately you did not passed the course.");
        }
    }
}