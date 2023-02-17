using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        string choice = "proceed";
        string input;
        Journal myJournal = new Journal();

        Console.WriteLine("Welcome to the Journal Program! "); // welcome at the beginning

        do // loop to pursue until 5 is given by the user
        {  
            // menu appears each time 
            Console.WriteLine("\nPlease select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
            Console.WriteLine("What would you like to do? ");
            // the choice of the user 
            input = Console.ReadLine();
            int  userChoice = int.Parse(input);

            if (userChoice == 1) // write
            {
                Entry entry = new Entry();
                entry._date = theCurrentTime.ToShortDateString();
                PromptQuoteGenerator promptEntry = new PromptQuoteGenerator();
                promptEntry.Generate();
                entry._quote = promptEntry._randomQuote;
                Console.WriteLine(entry._quote);
                entry._prompt = promptEntry._randomPrompt;
                Console.WriteLine($"\n {entry._prompt}");
                input = Console.ReadLine();
                string userResponse = input;
                entry._response = userResponse;
                myJournal._entries.Add(entry);
            }
            else if (userChoice == 2) // display the journal
            {
                 myJournal.DisplayJournal();
                  
            }
            else if (userChoice == 3) // load the journal
            {
                Console.WriteLine("What is the filename? ");
                input = Console.ReadLine();
                string userFileName = input;

                myJournal = new Journal();      //create a new journal with the data saved inside the _filename
                myJournal._fileName = userFileName;
                myJournal.LoadJournal();
                
            }
            else if (userChoice == 4) // save the journal
            {
                Console.WriteLine("Do you want ot save the quote too?(Y or N): ");
                input = Console.ReadLine();
                string userQuoteChoice = input;
                Console.WriteLine("What is the filename? ");
                input = Console.ReadLine();
                string userFileName = input;
                myJournal._fileName = userFileName;
                if (userQuoteChoice.ToUpper() == "Y")
                {
                    myJournal.SaveQuoteJournal();
                } else {
                myJournal.SaveJournal();
                }
            }
            else if (userChoice == 5) // quit the journal
            {
                Console.WriteLine("Good Bye!");
                choice = "finish";
            }
            else
            { // help when another number is written by the user
                Console.WriteLine("You have to choice between 1, 2, 3, 4, or 5"); 
            }
        } while (choice == "proceed");
    }
}
