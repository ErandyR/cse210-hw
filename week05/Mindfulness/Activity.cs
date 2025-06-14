
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void DisplayStartingMessage()
    {
        string startingMessage = $"Activity name: {_name} \n {_description}";
        Console.WriteLine(startingMessage);
        Console.Write("Enter the duration of the activity in seconds: \n >");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Let's begin...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You did a great job!");
        ShowSpinner(3);
        Console.WriteLine($"The duration of this activity was: {_duration} seconds");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            if (second < 10)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            else if (second >= 10)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b\b  \b\b");
            }
        }
    }

}