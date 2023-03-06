using System;

public abstract class Goal
{
    private string _goalName;
    private string _description;
    private int _points;
    private int _score;
    public Goal(string goalName, string description, int points)
    {
        _goalName = goalName;
        _description = description;
        _points = points;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
   

   public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }
    
    public abstract string CreateGoal();
    public abstract string RecordEvent(int score);

    public void MessageGoal(string typeOfGoal)
    {
        Console.WriteLine($"What is the name of your  {typeOfGoal}? ");
        _goalName = Console.ReadLine();
        SetGoalName(_goalName);
        _goalName = GetGoalName();
        
        Console.WriteLine("What is a short descritpion of it? ");
        _description = Console.ReadLine();
        SetDescription(_description);
        _description = GetDescription();

        Console.WriteLine($"What is the amount of points associated with this  {typeOfGoal}? ");
        _points = int.Parse(Console.ReadLine());
        SetPoints(_points); 
        _points = GetPoints(); 
    }
}