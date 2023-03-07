using System;

public class BadHabit : Goal
{
    private int _times;
    private int _malus;
    private int _number;

    public BadHabit(string goalName, string description, int points, int times, int malus, int number) : base(goalName, description, points)
    {
        _times = times;
        _malus = malus;
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

    public int GetMalus()
    {
        return _malus;
    }

    public void SetMalus(int malus)
    {
        _malus = malus;
    }

    public int GetNumberOfTimes()
    {
        return _number;
    }

    public void SetNumberOfTimes(int number)
    {
        _number = number;
    }

    public void NextMessage()
    {
        Console.WriteLine("How many times does this bad habit accomplish for a malus? ");
        _times = int.Parse(Console.ReadLine());
        SetTimes(_times);
        _times = GetTimes();
        Console.WriteLine("What is the malus for accomplishing it that many times? ");
        _malus = int.Parse(Console.ReadLine());
        SetMalus(_malus);
        _malus = GetMalus();
    }

    public override string CreateGoal()
    {
        string sgoal = "";
        //SetNumberOfTimes(0);
        CheckListGoal goal = new CheckListGoal(GetGoalName(), GetDescription(), GetPoints(), GetTimes(), GetMalus(), GetNumberOfTimes());
        sgoal = $"Bad habit: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}, {GetMalus().ToString()}, {GetTimes().ToString()}, {GetNumberOfTimes().ToString()}";
        return sgoal;
    }

    public override string RecordEvent(int sc)
    {
        CheckListGoal goal = new CheckListGoal(GetGoalName(), GetDescription(), GetPoints(), GetTimes(), GetMalus(), GetNumberOfTimes());
        string sGoal = "";

        SetNumberOfTimes(GetNumberOfTimes() + 1);
        GetNumberOfTimes();

        sGoal = $"Bad habit: {GetGoalName()}, {GetDescription()}, {GetPoints().ToString()}, {GetMalus().ToString()}, {GetTimes().ToString()}, {GetNumberOfTimes().ToString()}";
        Console.WriteLine($"You have lost {GetPoints().ToString()} points.");

        if (GetNumberOfTimes() < GetTimes())
        {
            Console.WriteLine("Remember that you can do it! Hold on!");
            // new score
            SetScore(sc - GetPoints());
            Console.WriteLine($"You now have {GetScore()} points.");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"You have lost {GetMalus().ToString()} points of Malus.");
            //new score
            SetScore(sc - GetPoints() - GetMalus());
            Console.WriteLine($"You now have {GetScore()} points.");
            Thread.Sleep(2000);
            Console.WriteLine($"Think about what you can do to choose better next time.");
            Thread.Sleep(3000);
            Console.Clear();
        }
        return sGoal;
    }
}