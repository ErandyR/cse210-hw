using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity runningActivity = new RunningActivity("Running", 3, 25);

        CyclingActivity cyclingActivity = new CyclingActivity("Cycling", 30, 60);

        SwimmingActivity swimmingActivity = new SwimmingActivity("Swimming", 12, 60);

        List<Activity> activities = new List<Activity>();
        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}