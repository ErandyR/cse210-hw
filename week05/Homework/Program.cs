using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Danna", "Encapsulation");
        string summary = assignment1.GetSummary();
        Console.WriteLine(summary);

        MathAssignment mathAssignment1 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment1.GetSummary());
        Console.WriteLine(mathAssignment1.GetHomeworkList());

        WritingAssignment writingAssignment1 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment1.GetSummary());
        Console.WriteLine(writingAssignment1.GetWritingInformation());

    }
}