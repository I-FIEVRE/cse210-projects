using System;

public class Save
{
    public void SaveGoals(List<string> entriesOfGoals, int score)
    {
        Console.WriteLine("What is the filename? ");
        string userFileName = Console.ReadLine();
        {
            using (StreamWriter outputFile = new StreamWriter(userFileName))
            {
                outputFile.Write($"{score}\n");
                foreach (string  goal in entriesOfGoals)
                {
                    outputFile.Write($"{goal}\n");
                }       
            }              
        }     
    }
}
