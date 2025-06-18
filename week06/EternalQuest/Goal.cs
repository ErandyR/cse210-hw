using System;

public class Goal
{
    private string _shortName;
    private string _description;
    private int _points;


    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }

    public virtual void RecordEvent()
    {

    }

    public virtual bool IsComplete()
    {
        return false;
    }

    public virtual string GetDetailsString()
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
        return $"{checkbox} {_shortName} ({_description})";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName},{_description},{_points}";

    }
}