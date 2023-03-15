using System;


public class FlexibleExpense : Entry
{
    public FlexibleExpense(string name, double amount) : base(name, amount)
    {
    }
   
    public override string NewEntry(double totalExpense)
    {
        string fExpense = "";
        Message("Flexible Expense");
        FlexibleExpense expense = new FlexibleExpense(GetName(), GetAmount());
        fExpense = $"Flexible Expense: {GetName()}, {GetAmount().ToString()}";
        SetTotalExpense(totalExpense + GetAmount());
        return fExpense;
    }

    public override string NewAmount(List<string> listOfEntries, double total)
    {
       Display d = new Display();
        string lEntry = "";
        string nEntry = "";
        string fExpense = "";
        Message("Flexible Expense");
        foreach (string entry in listOfEntries)
        {
            nEntry = d.GetKindEntryPart(entry);
            lEntry = d.GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (items[0].ToLower() == GetName().ToLower())
            {
                FlexibleExpense expense = new FlexibleExpense(items[0],  GetAmount());
                fExpense = $"Flexible Expense: {items[0]}, {GetAmount().ToString()}";
                SetTotalExpense(total - double.Parse(items[1]) + GetAmount());
                listOfEntries.Remove(entry);
                break;
            }
        } 
        return fExpense;  
    }
    
}