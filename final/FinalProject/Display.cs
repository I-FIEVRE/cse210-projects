using System;

public class Display
{
    private double _totalFixedExpense;

    public double GetTotalFixedExpense()
    {
        return _totalFixedExpense;
    }

    public void SetTotalFixedExpense(double totalFixedExpense)
    {
        _totalFixedExpense = totalFixedExpense;
    }
    public string GetKindEntryPart(string entry)
    {
        string[] parts = entry.Split(": ");
        string nEntry = parts[0];
        return nEntry;
    }

    public string GetEntryDetailPart(string entry)
    {
        string[] parts = entry.Split(": ");
        string nentry = parts[0];
        string lentry = parts[1];
        return lentry;
    }

    public void DisplayListOfType(string typeOfEntry, List<string> listOfEntries)
    {
        Console.WriteLine($"The {typeOfEntry}s are:");
        int i = 1;
        string lEntry = "";
        string nEntry = "";
        double totalAmount = 0;
        foreach (string entry in listOfEntries)
        {
            nEntry = GetKindEntryPart(entry);
            lEntry = GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (nEntry.ToLower() == typeOfEntry.ToLower())
            {
                Console.WriteLine($"{items[0]}: ${items[1]}");
                totalAmount = totalAmount + double.Parse(items[1]);   
            }
            i++;
        }
        Console.WriteLine($"The total of the {typeOfEntry}s is : ${totalAmount}");   
    }
    
    public double TotalAmountType (string typeOfEntry, List<string> listOfEntries)
    {
        int i = 1;
        string lEntry = "";
        string nEntry = "";
        double totalAmount = 0;
        foreach (string entry in listOfEntries)
        {
            nEntry = GetKindEntryPart(entry);
            lEntry = GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (nEntry.ToLower() == typeOfEntry.ToLower())
            {
                totalAmount = totalAmount + double.Parse(items[1]);   
            }
            i++;
        }
        return totalAmount;
    }
    public void DisplayTotalFixedExpense(List<string> entriesOfExpenses)
    {
        int i = 1;
        string lEntry = "";
        string nEntry = "";
        double totalAmount = 0;
        foreach (string entry in entriesOfExpenses)
        {
            nEntry = GetKindEntryPart(entry);
            lEntry = GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (nEntry.ToLower() == "fixed expense")
            {
                totalAmount = totalAmount + double.Parse(items[2]);   
            }
            i++;
        }
        Console.WriteLine($"The total of the Fixed Expenses is : ${totalAmount}"); 
    }
    
    public void DisplayListOfCategory(List<string> listOfEntries, string category, double totalFixedExpense)
    {
        Console.WriteLine($"{category.ToUpper()}");
        int i = 1;
        string lEntry = "";
        double totalAmount = 0;
        foreach (string entry in listOfEntries)
        {
            lEntry = GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (items[0].ToLower() == category.ToLower())
            {
                Console.WriteLine($"{items[1]}: ${items[2]}");
                totalAmount = totalAmount + double.Parse(items[2]);   
            }
            i++;
        }
        Console.WriteLine($"The total of  {category.ToUpper()} expense is : ${totalAmount}"); 
    }
    
}  