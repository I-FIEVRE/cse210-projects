using System;

public class Load
{
    public virtual void LoadGoals(List<string> entriesOfGoals, string userFileName)
    {    
        string[] lines = System.IO.File.ReadAllLines(userFileName);
        int i = 1;            
            foreach (string line in lines)
            {
                Display d = new Display();
                string nGoal = d.GetKindGoalPart(line);

                if (nGoal == "Simple goal")
                {
                    string lGoal = d.GetGoalDetailPart(line);
                    string[] items = lGoal.Split(", ");    
                    SimpleGoal sGoal = new SimpleGoal(items[0], items[1], int.Parse(items[2]));
                    string stringGoal = $"Simple goal: {items[0]}, {items[1]}, {items[2]}, {items[3]}";
                    entriesOfGoals.Add(stringGoal);    
                }
                else if (nGoal == "Checklist goal")
                {
                    string lGoal = d.GetGoalDetailPart(line);
                    string[] items = lGoal.Split(", ");
                    CheckListGoal sGoal = new CheckListGoal(items[0], items[1], int.Parse(items[2]), int.Parse(items[4]), int.Parse(items[3]), int.Parse(items[5]));
                    string stringGoal = $"Checklist goal: {items[0]}, {items[1]}, {items[2]}, {items[3]}, {items[4]}, {items[5]}";
                    entriesOfGoals.Add(stringGoal);
                }
                else if (nGoal == "Eternal goal")
                {
                    string lGoal = d.GetGoalDetailPart(line);
                    string[] items = lGoal.Split(", ");
                    EternalGoal sGoal = new EternalGoal(items[0], items[1], int.Parse(items[2]));
                    string stringGoal = $"Eternal goal: {items[0]}, {items[1]}, {items[2]}";
                    entriesOfGoals.Add(stringGoal);
                }
                else if (nGoal == "Bad habit")
                {
                    string lGoal = d.GetGoalDetailPart(line);
                    string[] items = lGoal.Split(", ");
                    CheckListGoal sGoal = new CheckListGoal(items[0], items[1], int.Parse(items[2]), int.Parse(items[4]), int.Parse(items[3]), int.Parse(items[5]));
                    string stringGoal = $"Bad habit: {items[0]}, {items[1]}, {items[2]}, {items[3]}, {items[4]}, {items[5]}";
                    entriesOfGoals.Add(stringGoal);
                }
            }
        i++;
    }

    public int ReturnScore(List<string> entriesOfGoals,string userFileName)
    {
        int score = 0;
        //first line: the score
		string[] liness = System.IO.File.ReadAllLines(userFileName);
        score = int.Parse(liness[0]);
        //Console.WriteLine( $"You have {score} point");
        return score;
    }    
}    