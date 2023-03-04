using System;

public class CheckListGoal : Goal
{
    private int _times;
    private int _bonus;
    private int _number;

    public CheckListGoal(string goalName, string description, int points, int times, int bonus, int number) : base(goalName, description, points)
    {
        _times = times;
        _bonus = bonus;
        _number = number;
    }

    public int GetTimes()
    {
        return _times;
    }

    public void SetTimes(int times)
    {
        _times = times;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetNumberOfTimes()
    {
        return _number;
    }

    public void SetNumberOfTimes(int number)
    {
        _number = number;
    }

    public void NextMessageGoal()
    {  
        Console.WriteLine("How many times does this goal accomplish for a bonus? ");
        _times = int.Parse(Console.ReadLine());
        SetTimes(_times);
        _times = GetTimes(); 
         Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        SetBonus(_bonus);
        _bonus = GetBonus(); 
    }

    public override string CreateGoal()
    {
        string sgoal = "";
        //SetNumberOfTimes(0);
        CheckListGoal goal = new CheckListGoal(GetGoalName(), GetDescription(), GetPoints(), GetTimes(), GetBonus(), GetNumberOfTimes());
        sgoal = $"Checklist goal: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}, {GetBonus().ToString()}, {GetTimes().ToString()}, {GetNumberOfTimes().ToString()}";
        return sgoal;
    }

    public override string RecordEvent(int sc)
    {
        CheckListGoal goal = new CheckListGoal(GetGoalName(), GetDescription(), GetPoints(), GetTimes(), GetBonus(), GetNumberOfTimes());
        string sGoal = "";

        SetNumberOfTimes(GetNumberOfTimes() + 1);
        GetNumberOfTimes();
        
        sGoal = $"Checklist goal: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}, {GetBonus().ToString()}, {GetTimes().ToString()}, {GetNumberOfTimes().ToString()}";
        if (GetNumberOfTimes() < GetTimes())
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints().ToString()} points.");
              
            SetScore(sc + GetPoints());
            Console.WriteLine($"You now have {GetScore()} points.\n\n");   
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {GetPoints().ToString()} points.");
            Console.WriteLine($"Congratulations! You have earned {GetBonus().ToString()} points of bonus.");
    
            SetScore(sc + GetPoints() + GetBonus());
            Console.WriteLine($"You now have {GetScore()} points.\n\n");    
        }
       return sGoal; 
    }   
}    