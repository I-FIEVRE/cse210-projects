using System;
using System.IO; 

public class Entry
{ 
   public string _date;
   public string _quote;
   public string _prompt;
   public string _response;
   
   public void Display()
   //Display the written details of an entry
   {
    Console.WriteLine(_quote);  
    Console.WriteLine($"Date: {_date} - Prompt: {_prompt} \n {_response}");
   }
}