using System;
using System.Drawing;
using System.Formats.Tar;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;


    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {

        _target = target;
        _bonus = bonus;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetCompleted(int count)
    {
        _amountCompleted = count;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        string checkbox;
        if (IsComplete() == true)
        {
            checkbox = "[X]";
        }
        else
        {
            checkbox = "[ ]";
        }
        return $"{checkbox} {GetName()} ({GetDescription()}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_target},{_bonus},{_amountCompleted}";

    }
}