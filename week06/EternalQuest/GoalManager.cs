using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager()
    {

    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create New Goal.");
            Console.WriteLine("2. List Goals.");
            Console.WriteLine("3. Save Goals.");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            string menuChoice = Console.ReadLine();

            if (menuChoice == "1")
            {
                CreateGoal();
            }
            else if (menuChoice == "2")
            {
                ListGoalDetails();
            }
            else if (menuChoice == "3")
            {
                SaveGoals();
            }
            else if (menuChoice == "4")
            {
                LoadGoals();
            }
            else if (menuChoice == "5")
            {
                RecordEvent();
            }
            else if (menuChoice == "6")
            {
                break;
            }
            else
            {
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalName()
    {
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }

    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("Which type of goal would you like to create: ");
        string typeOfGoal = Console.ReadLine();
        Console.WriteLine("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        int points = int.Parse(Console.ReadLine());
        if (typeOfGoal == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
            _goals.Add(simpleGoal);
        }
        else if (typeOfGoal == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, description, points);
            _goals.Add(eternalGoal);
        }
        else if (typeOfGoal == "3")
        {
            Console.WriteLine("How many time does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish? ");

        int choice = int.Parse(Console.ReadLine()) - 1;

        if (choice >= 0 && choice < _goals.Count)
        {
            Goal selectedGoal = _goals[choice];
            selectedGoal.RecordEvent();

            _score += selectedGoal.GetPoints();
            int pointsReceived = selectedGoal.GetPoints();
            if (selectedGoal is ChecklistGoal checklist && checklist.IsComplete())
            {
                _score += checklist.GetBonus();
                ShowCelebrationAnimation(); //calling the method for the celebration.
            }
            Console.WriteLine($"Congratulations! You have earned {pointsReceived} points!");
            Console.WriteLine($"Your new score is {_score}!\n");
        }
    }

    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }

        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(",");

            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);


            if (type == "SimpleGoal")
            {
                bool isComplete = bool.Parse(parts[4]);
                SimpleGoal goal = new SimpleGoal(name, description, points);
                if (isComplete == true)
                {
                    goal.RecordEvent();
                }
                _goals.Add(goal);
            }
            else if (type == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            else if (type == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);
                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                checklistGoal.SetCompleted(amountCompleted);
                _goals.Add(checklistGoal);
            }
        }
    }


    //adding a method for celebration when target for checklistGoal is completed
    private void ShowCelebrationAnimation()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("\n🎉🎉🎉 CONGRATULATIONS! 🎉🎉🎉\n");

        string[] confetti = {
        "  *  You're a rock star  *  ",
        "     *    *    *    *    *",
        "*   *   You're crushing it!   *   *",
        "   *   *    *    *    *  ",
        "*   🎉 Goal unlocked! 🎉   *"
        };

        foreach (string line in confetti)
        {
            Console.WriteLine(line);
            Thread.Sleep(300);
        }

        Console.ResetColor();
        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
        Console.Clear();
    }

}