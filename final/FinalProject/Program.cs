using System;

class Program
{
    static void Main(string[] args)
    {
       string userChoice = "";
        List<string> listOfEntries = new List<string>();
        List<string> listOfCategories = new List<string>();
        string  stringOfTotal = "";
        double totalFixedExpense = 0;
        double totalExpense = 0;
        double totalIncome = 0;
        double ceiling = 1;
        FixedExpense f1 = new FixedExpense("", "", 0);
        FlexibleExpense fl1 = new FlexibleExpense("", 0);
        DiscretionaryExpense d1 = new DiscretionaryExpense("", 0);
        FixedIncome i = new FixedIncome("", 0);
        ExceptionalIncome i1 = new ExceptionalIncome("", 0);
        Display d = new Display();

        do // loop to pursue until 6 is given by the user
        { 
            stringOfTotal = $"{totalIncome}, {totalExpense}, {ceiling}";
            // menu appears each time 
            Console.WriteLine("\nMenu Options: \n 1. New Expense \n 2. New Income \n 3. Display the Budget \n 4. Save Budget \n 5. Load Budget \n 6. Change an amount  \n 7. Change the ceiling \n 8. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            // the choice of the user 
            userChoice = Console.ReadLine();

            if (userChoice == "1")      //New Expense
            {
                string user2Choice = "";
                // menu
                Console.WriteLine("\nThe types of expense are:\n 1. Fixed Expense \n 2. Flexible Expense \n 3. Discretionary Expense \n 4. Return to main menu");
                Console.WriteLine("Wich type of expense do you like to create? ");
                // the choice of the user 
                user2Choice = Console.ReadLine();

                if (user2Choice == "1")      //New Fixed Expense
                {
                    Console.WriteLine("");
                    f1.FirstMessage();
                    listOfCategories.Add(f1.GetCategory());
                    listOfEntries.Add(f1.NewEntry(totalExpense));
                    totalExpense = f1.GetTotalExpense();
                    Console.WriteLine("");
                }
                else if (user2Choice == "2")        //New Flexible Expense
                {
                    listOfEntries.Add(fl1.NewEntry(totalExpense));
                    totalExpense = fl1.GetTotalExpense();
                    Console.WriteLine("");    
                }
                else if (user2Choice == "3")        //New Discretionary Expense        
                {
                    if (ceiling == 1)
                    {
                        //Choice of the ceiling by the user
                        d1.MessageCeiling();
                        ceiling = d1.GetCeiling();
                    }
                    //before expense total<ceiling
                    if (d.TotalAmountType("Discretionary Expense", listOfEntries) < ceiling)
                    {
                        d1.Message("Discretionary Expense");
                        double total = d.TotalAmountType("Discretionary Expense", listOfEntries) + d1.GetAmount();
                        if (total > ceiling)        //the new total would be heigher than the ceiling
                        {
                            Console.WriteLine($"\nThe amount is to heigh. You can only spend ${ceiling - d.TotalAmountType("Discretionary Expense", listOfEntries)}.");
                        }
                        else
                        {
                            listOfEntries.Add(d1.NewEntry(totalExpense));
                            totalExpense = d1.GetTotalExpense();
                            Console.WriteLine(""); 
                        }    
                    }
                    //before expense total=ceiling
                    else if (d.TotalAmountType("Discretionary Expense", listOfEntries) == ceiling)
                    {
                        Console.WriteLine("\nThe ceiling is reached. No more new Discretionary Expense possible.");
                    }   
                }
                else        //return to the inital menu
                {
                }
            }
            else if (userChoice == "2")     //New Income
            {    
                string user3Choice = "";
                // menu
                Console.WriteLine("\nThe types of income are:\n 1. Fixed Income \n 2. Exceptional Income \n 3. Return to main menu");
                Console.WriteLine("Wich type of income do you like to create? ");
                // the choice of the user 
                user3Choice = Console.ReadLine();
                if (user3Choice == "1")     //New Fixed Income
                {
                    listOfEntries.Add(i.NewEntry(totalIncome));
                    totalIncome = i.GetTotalIncome();
                    Console.WriteLine("");
                } 
                else if (user3Choice == "2")     //New Exceptional Income
                {
                    listOfEntries.Add(i1.NewEntry(totalIncome));
                    totalIncome = i1.GetTotalIncome();
                    Console.WriteLine("");
                } 
                else     //return to the initial menu 
                {
                }
            }
            else if (userChoice == "3")     // Display the Budget
            {
                string user5Choice = "";
                //menu
                Console.WriteLine("\nThe types of display are:\n 1. All the budget \n 2. All the income \n 3. All the Expenses \n 4. Resume \n 5. Return to main menu");
                Console.WriteLine("Wich type of display do you want? ");
                // the choice of the user 
                user5Choice = Console.ReadLine();
                if (user5Choice == "1")     //All the budget
                {
                    Console.Clear();
                    Console.WriteLine("\nYour Budget is: ");
                    d.DisplayListOfType("Fixed Income", listOfEntries);
                    d.DisplayTotalAmountType("Fixed Income", listOfEntries);
                    Console.WriteLine("");
                    d.DisplayListOfType("Exceptional Income", listOfEntries);
                    d.DisplayTotalAmountType("Exceptional Income", listOfEntries);
                    Console.WriteLine("");
                    List<string> cat = new List<string>();
                    Console.WriteLine("The Fixed Expenses are:");
                    foreach(string category in listOfCategories)
                    {
                        if (cat.Contains(category) == false )
                        {
                            d.DisplayListOfCategory(listOfEntries, category, totalFixedExpense);
                            cat.Add(category);
                        } 
                    }
                    d.DisplayTotalAmountType("Fixed Expense", listOfEntries);
                    Console.WriteLine("");
                    d.DisplayListOfType("Flexible Expense", listOfEntries);
                    d.DisplayTotalAmountType("Flexible Expense", listOfEntries);
                    Console.WriteLine("");
                    d.DisplayListOfType("Discretionary Expense", listOfEntries);
                    d.DisplayTotalAmountType("Discretionary Expense", listOfEntries);
                    Console.WriteLine($"Ceiling of Discretionary Expense: ${ceiling}");
                    Console.WriteLine("");
                    Console.WriteLine($"\nTotal expenses: ${totalExpense}");
                    Console.WriteLine($"Total incomes: ${totalIncome}");
                    Console.WriteLine($"Disposable Incomes: ${totalIncome - totalExpense}\n");

                }
                else if (user5Choice == "2")        //All the Income
                {
                    Console.Clear();
                    Console.WriteLine("\nYour income are: ");
                    d.DisplayListOfType("Fixed Income", listOfEntries);
                    d.DisplayTotalAmountType("Fixed Income", listOfEntries);
                    Console.WriteLine("");
                    d.DisplayListOfType("Exceptional Income", listOfEntries);
                    d.DisplayTotalAmountType("Exceptional Income", listOfEntries);
                    Console.WriteLine("");
                    Console.WriteLine($"Total incomes: ${totalIncome}");
                }
                else if (user5Choice == "3")        //All the expenses
                {
                    Console.Clear();
                    Console.WriteLine("\nYour expenses are: ");
                    List<string> cat = new List<string>();
                    Console.WriteLine("The Fixed Expenses are:");
                
                    foreach(string category in listOfCategories)
                    {
                        if (cat.Contains(category) == false )
                        {
                            d.DisplayListOfCategory(listOfEntries, category, totalFixedExpense);
                            cat.Add(category);
                        } 
                    }
                    d.DisplayTotalAmountType("Fixed Expense", listOfEntries);
                    Console.WriteLine("");
                    d.DisplayListOfType("Flexible Expense", listOfEntries);
                    d.DisplayTotalAmountType("Flexible Expense", listOfEntries);
                    Console.WriteLine("");
                    d.DisplayListOfType("Discretionary Expense", listOfEntries);
                    d.DisplayTotalAmountType("Discretionary Expense", listOfEntries);
                    Console.WriteLine($"Ceiling of Discretionary Expense: ${ceiling}");
                    Console.WriteLine("");
                    Console.WriteLine($"Total expenses: ${totalExpense}");

                }
                else if (user5Choice == "4")        //Resume
                {
                    Console.Clear();
                    Console.WriteLine($"\nTotal expenses: ${totalExpense}");
                    Console.WriteLine($"Total incomes: ${totalIncome}");
                    Console.WriteLine($"Disposable Incomes: ${totalIncome - totalExpense}\n");
                    Console.WriteLine($"Ceiling of Discretionary Expense: ${ceiling}");                   
                    d.DisplayTotalAmountType("Discretionary Expense", listOfEntries);
                } 
                else        //Return to the initial menu
                {
                }     
            }
            else if (userChoice == "4")     //Save Budget
            {
                Save s = new Save();
                s.SaveBudget(listOfEntries, listOfCategories, stringOfTotal);
            }
            else if (userChoice == "5")     //Load Budget
            {
                Console.WriteLine("What is the filename? ");
                string userFileName = Console.ReadLine();  
                Load l = new Load();
                l.LoadEntries(listOfEntries, userFileName);
                double totExp = l.ReturnTotalExpense(userFileName);
                double totInc = l.ReturnTotalIncome(userFileName);
                List<string>listOfCat = l.ReturnListOfCategories(userFileName);
                listOfCategories = listOfCat;
                FlexibleExpense f = new FlexibleExpense ("", 0); 
                f.SetTotalExpense(totExp);
                totalExpense = f.GetTotalExpense();
                f.SetTotalIncome(totInc);
                totalIncome = f.GetTotalIncome();
                ceiling = l.ReturnCeil(listOfEntries, userFileName);
            }
             else if (userChoice == "6")     //Change an amount
            {    
                string user4Choice = "";
                // menu
                Console.WriteLine("\nThe types of entrance are:\n 1. Fixed Income \n 2. Exceptional Income \n 3. Fixed Expense \n 4. Flexible Expense \n 5. Discretionary Expense \n 6. Return to main menu");
                Console.WriteLine("Wich type of entrance do you like to change? ");
                // the choice of the user 
                user4Choice = Console.ReadLine();
                if (user4Choice == "1")     //change Fixed Income
                {
                    listOfEntries.Add(i.NewAmount(listOfEntries, totalIncome));
                    totalIncome = i.GetTotalIncome();
                }  
                else if (user4Choice == "2")        //change Exceptional Income
                {
                    listOfEntries.Add(i1.NewAmount(listOfEntries, totalIncome));
                    totalIncome = i1.GetTotalIncome();
                }
                else if (user4Choice == "3")       //change Fixed Expense
                {
                    listOfEntries.Add(f1.NewAmount(listOfEntries, totalExpense));
                    totalExpense = f1.GetTotalExpense();
                }
                else if (user4Choice == "4")       //change Flexible Expense
                {
                    listOfEntries.Add(fl1.NewAmount(listOfEntries, totalExpense));
                    totalExpense = fl1.GetTotalExpense();
                }
                else if (user4Choice == "5")    //change Discretionary Expense        
                {
                    listOfEntries.Add(d1.NewAmount(listOfEntries, totalExpense));
                    totalExpense = d1.GetTotalExpense();
                }
                else        //return to the initial menu
                {
                }
            }
            else if (userChoice == "7")
            {
                d1.MessageCeiling();
                ceiling = d1.GetCeiling();
                Console.WriteLine($"The new ceiling is: {ceiling}");
            }
            else if (userChoice == "8")     //quit        
            {
                Console.WriteLine("Good Bye!\n"); 
            }
            else
            { // help when another word or character is written by the user
                Console.WriteLine("You have to choose between 1, 2, 3, 4, 5, 6, 7 or 8 "); 
            }
        } while (!(userChoice == "8"));       
    }    
}