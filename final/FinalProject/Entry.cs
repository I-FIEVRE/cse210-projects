using System;

public abstract class Entry
{
    private string _name;
    private double _amount;
    private double _totalExpense;
    private double _totalIncome;
    public Entry(string name, double amount)
    {
        _name = name;
        _amount = amount;       
    }
    
    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public double GetAmount()
    {
        return _amount;
    }

    public void SetAmount(double amount)
    {
        _amount = amount;
    }

   public double GetTotalExpense()
    {
        return _totalExpense;
    }

    public void SetTotalExpense(double totalExpense)
    {
        _totalExpense = totalExpense;
    }

    public double GetTotalIncome()
    {
        return _totalIncome;
    }

    public void SetTotalIncome(double totalIncome)
    {
        _totalIncome = totalIncome;
    }

    public abstract string NewEntry(double total);
    public abstract string NewAmount(List<string> listOfEntries, double total);
    
    public void Message(string typeOfEntry)
    {
        Console.WriteLine($"What is the name of your {typeOfEntry}? ");
        SetName(Console.ReadLine());
        Console.WriteLine($"What is the amount associated with this {typeOfEntry}? ");
        SetAmount( double.Parse(Console.ReadLine()));    
    }   

    
  
}