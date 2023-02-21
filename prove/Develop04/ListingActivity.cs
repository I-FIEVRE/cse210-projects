using System;


public class ListingActivity : Activity
{
    private List<string> _listOfQuestions = new List<string>() {"Who are people that you appreciate? ", "What are personal strengths of yours? ", "Who are people that you have helped this week?", 
    "When have you felt the Holy Ghost this month? ", "Who are some of your personal heroes? "};

    public ListingActivity(string activityName, string description, int duration): base(activityName, description, duration)
    {
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int rdIndex = rnd.Next(_listOfQuestions.Count);
        string question = _listOfQuestions[rdIndex];
        return question;
    }
    
    public void DisplayQuestion()
    {
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomQuestion()); 
        Console.Write("You may begin in: ");
        PauseCountdownShown(5);
        Console.WriteLine(" ");
    }

    public void GetAnswer()
    {
        string input;
        input = Console.ReadLine();
    }

    public void DisplayNumberOfItems()
    {
        DateTime startTime = DateTime.Now;
        double time = GetDuration();
        DateTime futureTime = startTime.AddSeconds(time);       //for the duration of the activity
        DateTime currentTime = DateTime.Now;
        int count = 0;
        //the loop to count the number of items during the duration of the activity
        while (currentTime < futureTime)
        {
            GetAnswer();
            count++;
            currentTime = DateTime.Now;   
        }
        //dispaly the number of items
        Console.WriteLine($"\nYou listed {count} items!");
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        DisplayQuestion();
        DisplayNumberOfItems();
        DisplayEndingMessage();
        SaveActivity();
    }
}