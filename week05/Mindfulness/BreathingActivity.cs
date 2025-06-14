

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }
    public void Run()
    {
        DisplayStartingMessage();
        int inActivity = 0;
        while (inActivity < GetDuration())
        {
            Console.WriteLine("Breath in...");
            ShowCountDown(4);

            inActivity += 4;
            if (inActivity >= GetDuration())
            {
                break;
            }

            Console.WriteLine("Breath out...");
            ShowCountDown(6);

            inActivity += 6;
        }
        DisplayEndingMessage();
    }
}