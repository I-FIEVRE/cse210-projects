using System;


public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;

   

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



    public void DisplayStartingMessage()
    {
        Console.WriteLine($"\nWelcome to the {_activityName}. \n\n{_description} \n\nHow long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        int duration = int.Parse(input);
        SetDuration(duration);
        Console.Clear();
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
}