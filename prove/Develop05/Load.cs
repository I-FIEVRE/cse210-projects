using System;

public class Load
{
    public virtual void LoadGoals(List<string> entriesOfGoals, string userFileName)
    {    
        string[] lines = System.IO.File.ReadAllLines(userFileName);
        int i = 1;            
        foreach (string line in lines)
        {
            if (i > 1)
            {
                Display d = new Display();
                string nGoal = d.GetKindGoalPart(line);
                string lGoal = d.GetGoalDetailPart(line);
                string stringGoal = $"{nGoal}: {lGoal}";
                entriesOfGoals.Add(stringGoal);  
                string[] items = lGoal.Split(", ");
                if (nGoal == "Simple goal")
                { 
                    SimpleGoal sGoal = new SimpleGoal(items[0], items[1], int.Parse(items[2]));  
                }
                else if (nGoal == "Checklist goal")
                {
                    CheckListGoal sGoal = new CheckListGoal(items[0], items[1], int.Parse(items[2]), int.Parse(items[4]), int.Parse(items[3]), int.Parse(items[5]));
                }
                else if (nGoal == "Eternal goal")
                {         
                    EternalGoal sGoal = new EternalGoal(items[0], items[1], int.Parse(items[2]));  
                }
                else if (nGoal == "Bad habit")
                {
                    CheckListGoal sGoal = new CheckListGoal(items[0], items[1], int.Parse(items[2]), int.Parse(items[4]), int.Parse(items[3]), int.Parse(items[5]));
                }
            }
            i++;
        }
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