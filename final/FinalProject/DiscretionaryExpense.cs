public class DiscretionaryExpense : Entry
{
    private double _ceiling;

    public DiscretionaryExpense(string name, double amount) : base(name, amount)
    {
    }

    public double GetCeiling()
    {
        return _ceiling;
    }

    public void SetCeiling(double ceiling)
    {
        _ceiling = ceiling;
    }

    public void MessageCeiling()
    {   
        Console.WriteLine($"What is the ceiling of your Discretionary Expenses? ");
        SetCeiling(double.Parse(Console.ReadLine())); 
    }  

    public override string NewEntry(double totalExpense)
    {
        string dExpense = "";
        DiscretionaryExpense expense = new DiscretionaryExpense(GetName(), GetAmount());
        dExpense = $"Discretionary Expense: {GetName()}, {GetAmount().ToString()}";
        SetTotalExpense(totalExpense + GetAmount());
        return dExpense;
    }

    public override string NewAmount(List<string> listOfEntries, double total)
    {
        Display d = new Display();
        string lEntry = "";
        string nEntry = "";
        string dExpense = "";
        foreach (string entry in listOfEntries)
        {
            nEntry = d.GetKindEntryPart(entry);
            lEntry = d.GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (items[0].ToLower() == GetName().ToLower())
            {
                DiscretionaryExpense expense = new DiscretionaryExpense(items[0],  GetAmount());
                dExpense = $"Discretionary Expense: {items[0]}, {GetAmount().ToString()}";
                SetTotalExpense(total - double.Parse(items[1]) + GetAmount());
                listOfEntries.Remove(entry);
                break;
            }             
        } 
        return dExpense;     
    }

}