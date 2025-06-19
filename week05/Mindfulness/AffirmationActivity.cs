using System;

//creating another activity to exceed the requirements
public class AffirmationActivity : Activity
{
    private List<string> _affirmations = new List<string>();

    public AffirmationActivity() : base("Visualization activity", "This activity will help you build confidence by reflecting on positive affirmations.")
    {
        _affirmations.Add("I am strong and capable.");
        _affirmations.Add("I am worthy of love.");
        _affirmations.Add("I grow and improve every day.");
        _affirmations.Add("I choose calm and peace.");
        _affirmations.Add("I trust myself.");
        _affirmations.Add("I am resilient.");
        _affirmations.Add("I deserve good things in life.");
        _affirmations.Add("I believe in myself.");
    }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            DisplayAffirmation();
            ShowSpinner(5);
        }

        DisplayEndingMessage();
    }
    public string GetRandomAffirmation()
    {
        int index = new Random().Next(_affirmations.Count);

        return _affirmations[index];
    }

    public void DisplayAffirmation()
    {
        Console.WriteLine($"\n>> {GetRandomAffirmation()}");
    }
}