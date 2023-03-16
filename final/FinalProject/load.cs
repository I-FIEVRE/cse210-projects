using System;

public class Load
{    
    public void LoadEntries(List<string> listOfEntries, string userFileName)
    {    
        string[] lines = System.IO.File.ReadAllLines(userFileName);
        int i = 1;            
        foreach (string line in lines)
        {
            if (i > 2)
            {
                Display d = new Display();
                string nEntry = d.GetKindEntryPart(line);
                string lEntry = d.GetEntryDetailPart(line);
                string stringEntry = $"{nEntry}: {lEntry}";
                listOfEntries.Add(stringEntry);  
                string[] items = lEntry.Split(", ");
            }
            i++;
        }
    }

    public List<string> ReturnListOfCategories(string userFileName)
    {
        List<string> listOfCategories = new List<string>();
       //the secondline: listOfCategories
        string[] liness = System.IO.File.ReadAllLines(userFileName);
        string line = liness[1];
        string[] items = line.Split(", ");
        foreach (var item in items)
        {
            listOfCategories.Add(item);
        }
        return listOfCategories;
    }

    public double ReturnCeil(List<string> listOfEntries, string userFileName)
    {
        double ceiling = 0;
        //third item of the firstline: ceiling
		string[] lines = System.IO.File.ReadAllLines(userFileName);
        string line = lines[0];
        string[] items = line.Split(", ");
        ceiling = double.Parse(items[2]);
        return ceiling;
    }


    public double ReturnTotalExpense(string userFileName)
    {
        double TotalExpense = 0;
        //second item of the firstline: totalExpense
		string[] lines = System.IO.File.ReadAllLines(userFileName);
        string line = lines[0];
        string[] items = line.Split(", ");
        TotalExpense = double.Parse(items[1]);
        return TotalExpense;
    }    

    public double ReturnTotalIncome(string userFileName)
    {
        double TotalIncome = 0;
        //first item of the firstline: totalIncome
		string[] liness = System.IO.File.ReadAllLines(userFileName);
        string line = liness[0];
        string[] items = line.Split(", ");
        TotalIncome = double.Parse(items[0]);;
        return TotalIncome;
    }    
}    