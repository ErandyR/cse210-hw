

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();

    private List<string> _questions = new List<string>();

    public ReflectingActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience?");
        _questions.Add("What did you learn about yourself?");
        _questions.Add("How can you keep this in mind in the future?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPropmt();
        ShowSpinner(5);

        Console.WriteLine("Now, reflect on questions that relate to this experience...");
        ShowSpinner(3);


        int inActivity = 0;

        while (inActivity < GetDuration())
        {
            DisplayQuestions();
            ShowSpinner(5);
            inActivity += 5;
        }

        DisplayEndingMessage();
    }
    public string GetRandomPrompt()
    {
        int index = new Random().Next(_prompts.Count);

        return _prompts[index];
    }
    public string GetRandomQuestion()
    {
        int index = new Random().Next(_questions.Count);

        return _questions[index];
    }

    public void DisplayPropmt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
    }
    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine(randomQuestion);
    }

}