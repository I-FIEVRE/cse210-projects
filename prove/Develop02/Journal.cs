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
    public void SaveJournal()
    // save the person's journal to a file.text (_fileName) by
    //iterating through each Entry instance save _quote in the list of entries 
    {
        using (StreamWriter outputFile = File.AppendText(_fileName))
        {
            foreach (Entry entry in _entries) 
            {
                string date = entry._date;
                string prompt = entry._prompt;
                string response = entry._response;
                outputFile.WriteLine($" \n Date: {date} - Prompt: {prompt} \n {response}");
            }
        }
    } 

    public void SaveQuoteJournal()
        // save the person's journal  with the quote(s) to a file.text (_fileName) by
        //iterating through each Entry instance in the list of entries 
        {
            using (StreamWriter outputFile = File.AppendText(_fileName))
            {
                foreach (Entry entry in _entries) 
                {
                    string date = entry._date;
                    string quote = entry._quote;
                    string prompt = entry._prompt;
                    string response = entry._response;
                    outputFile.WriteLine($" \n Quote: {quote} \n Date: {date} - Prompt: {prompt} \n {response}");
                }
            }
        } 

    public void LoadJournal()
    // load the person's journal from a file.text (_fileName) by
    //iterating through each line in the list of lines 
    {
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Console.WriteLine(line);
        }
    }    
}
        
    
