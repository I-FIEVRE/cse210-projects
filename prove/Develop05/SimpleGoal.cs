using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
    }
    
    public override string CreateGoal()
    {
        SimpleGoal goal = new SimpleGoal(GetGoalName(), GetDescription(), GetPoints());
        string sGoal = "";
        sGoal = $"Simple goal: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}, {!IsComplete()}";
        return sGoal;
        //Console.WriteLine($"{sgoal}");
    }
   
    public bool IsComplete()
    {
        return true;
    }

    public override string RecordEvent(int sc)
    {
        SimpleGoal goal = new SimpleGoal(GetGoalName(), GetDescription(), GetPoints());
        string sGoal = "";
        sGoal = $"Simple goal: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}, {IsComplete()}";
        Console.WriteLine($"Congratulations! You have earned {GetPoints().ToString()} points.");
        //int score = GetScore();
        //Console.WriteLine($"{sc}");
        SetScore(sc + GetPoints());
        Console.WriteLine($"You now have {GetScore()} points.\n\n");
        return sGoal;
    }   
}    