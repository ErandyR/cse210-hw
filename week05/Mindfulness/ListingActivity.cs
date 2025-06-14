

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    private List<string> listFromUser = new List<string>();


    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");

    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        ShowCountDown(5);
        Console.Write("Keep listing items:");
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            GetListFromUser();
        }
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} items!");
        ShowSpinner(3);
        DisplayEndingMessage();

    }
    public void GetRandomPrompt()
    {

        int index = new Random().Next(_prompts.Count);

        Console.WriteLine($"{_prompts[index]}");
    }
    public List<string> GetListFromUser()
    {
        Console.Write("> ");
        string newItem = Console.ReadLine();
        listFromUser.Add(newItem);
        return listFromUser;
    }
}