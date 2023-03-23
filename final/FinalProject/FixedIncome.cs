public class FixedIncome : Entry
{
    public FixedIncome(string name, double amount) : base(name, amount)
    {
    }

     public override string NewEntry(double totalIncome)
    {
        string fIncome = "";
        Message("Fixed Income");
        //FixedIncome income = new FixedIncome(GetName(), GetAmount());
        fIncome = $"Fixed Income: {GetName()}, {GetAmount().ToString()}";
        SetTotalIncome(totalIncome + GetAmount());
        return fIncome;
    }

    public override string NewAmount(List<string> listOfEntries, double total)
    {
        Display d = new Display();
        string lEntry = "";
        string nEntry = "";
        string fIncome = "";
        Message("Fixed Income");
        foreach (string entry in listOfEntries)
        {
            nEntry = d.GetKindEntryPart(entry);
            lEntry = d.GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (items[0].ToLower() == GetName().ToLower())
            {
                FixedIncome income = new FixedIncome(items[0],  GetAmount());
                fIncome = $"Fixed Income: {items[0]}, {GetAmount().ToString()}";
                SetTotalIncome(total - double.Parse(items[1]) + GetAmount());
                listOfEntries.Remove(entry);
                break;
            }
        } 
        return fIncome;  
    }

}