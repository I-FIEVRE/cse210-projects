using System;


public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

    private List<Activity> _entriesOfActivities = new List<Activity>();     //loading and saving 
   
    public Activity(string activityName, string description, int duration)
    {
        _activityName = activityName;
        _description = description;
        _duration = duration;
    }
    
    public string GetActivityName()
    {
        return _activityName;
    }
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void PauseSpinnerShown(int j, int k)
    {
        for (int i = 0; i < k; i++)
        {
        Console.Write("|");
        Thread.Sleep(j);
        Console.Write("\b \b"); // Erase the | character
        Console.Write("/"); // Replace it with the / character
        Thread.Sleep(j);
        Console.Write("\b \b"); // Erase the / character
        Console.Write("—"); // Replace it with the — character
        Thread.Sleep(j);
        Console.Write("\b \b"); // Erase the — character
        Console.Write("\\"); // Replace it with the \ character
        Thread.Sleep(j);
        Console.Write("\b \b"); // Erase the \ character
        }
    }

    public void PauseCountdownShown(int j)
    {
        for (int i = j; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void DisplayStartingMessage()        //display the starting message and load if the user . 
    {
        //first part of starting message
        Console.WriteLine($"\nWelcome to the {_activityName}. \n\n{_description} \n\nHow long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int duration = int.Parse(input);

        SetDuration(duration);
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Activity activity = new Activity(_activityName, _description, _duration);

        //change the descrition with the current date (loading and saving)
        activity._description = dateText;
        _entriesOfActivities.Add(activity);

        //calls the LoadActivities method
        LoadActivities();

        PauseSpinnerShown(500, 3);
        Console.Clear();

        //end of starting message
        Console.WriteLine("Get Ready...");
        PauseSpinnerShown(500, 3);
        Console.WriteLine(" ");
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"\nWell done!!");
        PauseSpinnerShown(500, 3);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}.");
        PauseSpinnerShown(500, 3);
        Console.Clear();
    }

    public void LoadActivities()
    {
        Console.WriteLine("Do you want to load?(Y or N): ");
        string userQuoteChoice = Console.ReadLine();
        if (userQuoteChoice.ToUpper() == "Y")
        {    
            Console.WriteLine("What is the filename? ");
            string userFileName = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(userFileName);
            int i = 1;
            foreach (string line in lines)
            {
                string[] parts = line.Split(" : ");
                string dat = parts[0];
                string act = parts[1];
                int dur = int.Parse(parts[2]);
                Activity activity = new Activity(act, dat, dur);
                _entriesOfActivities.Add(activity);
                Console.WriteLine($"{dat} the {act} was completed in {dur} seconds.");
            }
                i = i + 1;
        }
    }  

    public void SaveActivity()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        Console.WriteLine("Do you want to save this activity?(Y or N): ");
        string userQuoteChoice = Console.ReadLine();
        if (userQuoteChoice.ToUpper() == "Y")
        {
            Console.WriteLine("What is the filename? ");
            string userFileName = Console.ReadLine();
            {
                using (StreamWriter outputFile = new StreamWriter(userFileName))
                {
                    foreach (Activity activity in _entriesOfActivities)
                    {
                        string activityName = activity._activityName;
                        int duration = activity._duration;
                        string date = activity._description;
                        if (date != dateText)
                        {
                            outputFile.Write($"{date} : {activityName} : {duration} \n");
                        }
                        else
                        {
                            outputFile.Write($"{dateText} : {activityName} : {duration} \n");
                        }
                    }   
                }              
            }     
        }           
    }
      
}