using System;

public class Resume
{
    public string _name = "";
    // or public string _name;
    public List<Job> _jobs = new List<Job>{};

    public void DisplayResume()
    //display the person's name and then 
    //iterate through each Job instance in the list of jobs 
    //and display them.
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (var job in _jobs) // or foreach (Job job in _jobs)
         {
            //call the Display method on each job
            job.Dispaly();
        }
    }


}