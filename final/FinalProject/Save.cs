using System;

public class Save
{
    public void SaveBudget(List<string> listOfEntries, List<string> listOfCategories, string stringOfTotal)
    {
        Console.WriteLine("What is the filename? ");
        string userFileName = Console.ReadLine();
        {
            using (StreamWriter outputFile = new StreamWriter(userFileName))
            {
                outputFile.Write($"{stringOfTotal}\n");
                string st = string.Join(", ", listOfCategories);
                outputFile.Write($"{st}");
                foreach (string entry in listOfEntries)
                {
                    outputFile.Write($"\n{entry}");
                }       
            }              
        }     
    }
}
