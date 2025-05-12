using System;

class Program
{
    static void Main(string[] args)
    {
        DisplaysWelcome();

        string userName = PromptUserName();

        int userNumber = PromptUserNumber();

        int numberSquared = SquareNumber(userNumber);

        DisplayResult(userName, numberSquared);
    }
    static void DisplaysWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name:");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number:");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string userName, int square)
    {
        string strSquare = square.ToString();
        Console.WriteLine($"{userName}, the square of your number is {strSquare}");
    }
}