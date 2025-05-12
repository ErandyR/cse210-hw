using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {

        List<int> numbersList = new List<int>();

        int userNumber = -1;

        while (userNumber != 0)
        {
            Console.WriteLine("Enter a number:");
            string userAnswer = Console.ReadLine();
            userNumber = int.Parse(userAnswer);

            if (userNumber != 0)
            {
                numbersList.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbersList)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");


        float average = ((float)sum) / numbersList.Count;
        Console.WriteLine($"The average is: {average}");


        int maxNumber = numbersList[0];

        foreach (int number in numbersList)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        Console.WriteLine($"The max number is: {maxNumber}");

    }
}