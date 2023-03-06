using System;

public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string description, int points) : base(goalName, description, points)
    {
    }

    public override string CreateGoal()
    {
        string egoal = "";
        EternalGoal goal = new EternalGoal(GetGoalName(), GetDescription(), GetPoints());
        egoal = $"Eternal goal: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}";
        return egoal;
    }
    
    public override string RecordEvent(int sc)
    {
        EternalGoal goal = new EternalGoal(GetGoalName(), GetDescription(), GetPoints());
        string sGoal = "";
        sGoal = $"Eternal goal: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}";
        Console.WriteLine($"\nCongratulations! You have earned {GetPoints().ToString()} points.");
         //new score
        SetScore(sc + GetPoints());
        Console.WriteLine($"You now have {GetScore()} points.");
        Thread.Sleep(2000);
        Console.Clear();
        return sGoal;
    }   
}    