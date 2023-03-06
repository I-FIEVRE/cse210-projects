using System;

public class Display
{
    public string GetKindGoalPart(string goal)
    {
        string[] parts = goal.Split(": ");
        string nGoal = parts[0];
        return nGoal;
    }

    public string GetGoalDetailPart(string goal)
    {
        string[] parts = goal.Split(": ");
        string nGoal = parts[0];
        string lGoal = parts[1];
        return lGoal;
    }

    public void DisplayListOfGoals(List<string> entriesOfGoals)
    {
        Console.WriteLine("The goals are:");
        int i = 1;
        string lGoal = "";
        string nGoal = "";
        foreach (string goal in entriesOfGoals)
        {
            nGoal = GetKindGoalPart(goal);
            lGoal = GetGoalDetailPart(goal);
            string[] items = lGoal.Split(", ");
            
            if (nGoal == "Simple goal")
            {
                if (items[3] == "True")
                {
                    Console.WriteLine($"{i}. [X] {items[0]} ({items[1]})");
                }
                else if (items[3] == "False")
                {
                    Console.WriteLine($"{i}. [ ] {items[0]} ({items[1]})");
                }   
            }
            else if (nGoal == "Checklist goal")
            {
                if (items[4] == items[5])
                {
                    Console.WriteLine($"{i}. [X] {items[0]} ({items[1]}) -- Currently completed: {items[5]}/{items[4]}");
                }
                else 
                {
                    Console.WriteLine($"{i}. [ ] {items[0]} ({items[1]}) -- Currently completed: {items[5]}/{items[4]}");
                }       
            }
            else if (nGoal == "Eternal goal")
            {
                Console.WriteLine($"{i}. [ ] {items[0]} ({items[1]})");
            }
             else if (nGoal == "Bad habit")
            {
                if (items[4] == items[5])
                {
                    Console.WriteLine($"{i}. [X] {items[0]} ({items[1]}) -- Currently completed: {items[5]}/{items[4]}");
                }
                else 
                {
                    Console.WriteLine($"{i}. [ ] {items[0]} ({items[1]}) -- Currently completed: {items[5]}/{items[4]}");
                }       
            }
            i++;
        }   
    }

    public void DisplayListOfGoals2(List<string> entriesOfGoals)
    {
        Console.WriteLine("\nThe goals are:");
        int i = 1;
        string lGoal = "";
        string nGoal = "";
        foreach (string goal in entriesOfGoals)
        {
            nGoal = GetKindGoalPart(goal);
            lGoal = GetGoalDetailPart(goal);
            string[] items = lGoal.Split(", ");
            
            if (nGoal == "Simple goal")
            {
                Console.WriteLine($"{i}. {items[0]}");
            }
            else if (nGoal == "Checklist goal")
            {
                Console.WriteLine($"{i}. {items[0]}");
            }
            else if (nGoal == "Eternal goal")
            {
                Console.WriteLine($"{i}.{items[0]}");
            }
            else if (nGoal == "Bad habit")
            {
                Console.WriteLine($"{i}.{items[0]}");
            }
            i++;
        }   
    }
}   