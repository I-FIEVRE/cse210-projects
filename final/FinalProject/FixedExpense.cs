using System;


public class FixedExpense : Entry
{
    private string _category;
   
    public FixedExpense(string category, string name, double amount) : base(name, amount)
    {
        _category = category;
    }

    public string GetCategory()
    {
        return _category;
    }

    public void SetCategory(string category)
    {
        _category = category;
    }

    public void FirstMessage()
    {
        Console.WriteLine($"What is the category of your Fixed Expense? ");
        SetCategory(Console.ReadLine());
        _category = GetCategory();
    }
    public override string NewEntry(double totalExpense)
    {
        string fExpense = "";
        Message("Fixed Expense");
        FixedExpense expense = new FixedExpense(GetCategory(), GetName(), GetAmount());
        fExpense = $"Fixed Expense: {GetCategory()}, {GetName()}, {GetAmount().ToString()}";
        SetTotalExpense(totalExpense + GetAmount());
        return fExpense;
    }

    public override string NewAmount(List<string> listOfEntries, double total)
    {
        Display d = new Display();
        string lEntry = "";
        string nEntry = "";
        string fExpense = "";
        Message("Fixed Expense");
        foreach (string entry in listOfEntries)
        {
            nEntry = d.GetKindEntryPart(entry);
            lEntry = d.GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (items[1].ToLower() == GetName().ToLower())
            {
                FixedExpense expense = new FixedExpense(items[0], items[1], GetAmount());
                fExpense = $"Fixed Expense: {items[0]}, {items[1]}, {GetAmount().ToString()}";
                expense.SetTotalExpense(total - double.Parse(items[2]) + GetAmount());
                listOfEntries.Remove(entry);
                break;
            }
        } 
        return fExpense;     
    }
    
}
