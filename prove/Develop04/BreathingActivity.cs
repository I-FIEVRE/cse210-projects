using System;


public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description, int duration): base(activityName, description, duration)
    {
    }

    public void DisplayMessage()
    {
        double time = GetDuration();
        int res = Convert.ToInt32(time);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(time);       //for the duration of the activity
        DateTime currentTime = DateTime.Now;
        
        if (!(res % 10 == 0))       //to adapt a little the breaths to the duration of the activity(res)
        {
            int nbr = res % 10;
            if (nbr %2 == 0)
            {
                Console.Write("\nBreathe in...");
                PauseCountdownShown(nbr / 2);
                Console.Write("\nBreathe out...");
                PauseCountdownShown(nbr / 2);
                Console.WriteLine(" ");
                currentTime = DateTime.Now;
            } 
            else
            {
                Console.Write("\nBreathe in...");
                PauseCountdownShown(nbr / 2);
                Console.Write("\nBreathe out...");
                PauseCountdownShown(nbr / 2 + 1);
                Console.WriteLine(" ");
                currentTime = DateTime.Now;
            }     
        }
        while (currentTime < futureTime)        //loop for the duration of the activity
        {
            Console.Write("\nBreathe in...");
            PauseCountdownShown(5);
            Console.Write("\nBreathe out...");
            PauseCountdownShown(5);
            Console.WriteLine(" ");
            currentTime = DateTime.Now;
        }
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        DisplayMessage(); 
        DisplayEndingMessage();   
    }
}