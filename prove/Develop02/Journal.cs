using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>{};
    public void DisplayJournal()
    //display the person's journal by
    //iterating through each Entry instance in the list of entries 
    //and display them.
    {
        foreach (Entry entry in _entries) 
        {
            //call the Display method on each entry
            entry.Display();
        }
    }
    
    public string _fileName;

    public void SaveQuoteJournal() 
        // save the person's journal  with the quote(s) to a file.text (_fileName) by
        //iterating through each Entry instance in the list of entries 
        {
            using (StreamWriter outputFile = new StreamWriter(_fileName))
            {
                foreach (Entry entry in _entries) 
                {
                    string date = entry._date;
                    string quote = entry._quote;
                    string prompt = entry._prompt;
                    string response = entry._response;
                    outputFile.WriteLine($"{quote} \n {date} - {prompt} \n {response}");
                }
            }
        } 


    public void SaveJournal()
    // save the person's journal to a file.text (_fileName) by
    //iterating through each Entry instance save _quote in the list of entries 
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _entries) 
            {
                string date = entry._date;
                string prompt = entry._prompt;
                string response = entry._response;
                outputFile.WriteLine($"\n {date} - {prompt} \n {response}");
            }
        }
    } 
   

    public void LoadJournal()
    // load the person's journal from a file.text (_fileName) by
    //iterating through each line in the list of lines 
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        int i = 1;
        string date = "";
        string prompt = "";
        string quote = "";

        foreach (string line in lines)
        {
            if (i == 1)
            {
                quote = line;
                i = i + 1;
            }   
            else if (i == 2)
            {
                string[] parts = line.Split(" - ");
                date = parts[0];
                prompt = parts[1];
                i = i + 1;
            }
            else
            {
                Entry entry = new Entry();
                entry._quote = quote;
                entry._date = date;
                entry._prompt = prompt;
                entry._response = line;
                
                 _entries.Add(entry); 
                i = 1;   
            }             
        }
    }    

}
/* When loading the file it should load it into the list of entries so that more can be added and then all can be displayed together.*/
/*Lors du chargement du fichier, il doit le charger dans la liste des entrées afin que d'autres puissent être ajoutées et ensuite toutes puissent être affichées ensemble.*/  
