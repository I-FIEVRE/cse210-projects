public class ExceptionalIncome : Entry
{
    public ExceptionalIncome(string name, double amount) : base(name, amount)
    {
    }
   
    public override string NewEntry(double totalIncome)
    {
        string eIncome = "";
         Message("Exceptional Income");
        ExceptionalIncome income = new ExceptionalIncome(GetName(), GetAmount());
        eIncome = $"Exceptional Income: {GetName()}, {GetAmount().ToString()}";
        SetTotalIncome(totalIncome + GetAmount());
        return eIncome;
    }
    
    public override string NewAmount(List<string> listOfEntries, double total)
    {
       Display d = new Display();
        string lEntry = "";
        string nEntry = "";
        string eIncome = "";
        Message("Exceptional Income");
        foreach (string entry in listOfEntries)
        {
            nEntry = d.GetKindEntryPart(entry);
            lEntry = d.GetEntryDetailPart(entry);
            string[] items = lEntry.Split(", "); 
            if (items[0].ToLower() == GetName().ToLower())
            {
                ExceptionalIncome income = new ExceptionalIncome(items[0],  GetAmount());
                eIncome = $"Exceptional Income: {items[0]}, {GetAmount().ToString()}";
                SetTotalIncome(total - double.Parse(items[1]) + GetAmount());
                listOfEntries.Remove(entry);
                break;
            }
        } 
        return eIncome;  
    }
    
}