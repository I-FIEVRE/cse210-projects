using System;
public class Job
{ 
   public string _company = "";
   // or public string _company;
   public string  _jobTitle = "";
   public int _startYear = 0;
   // or public int _startYear;
   public int _endYear = 0;
   
   public void Dispaly()
   //Display job details
   {
    Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
   }
}