using System;


public class ReflectingActivity : Activity
{
    private List<string> _listOfPrompts = new List<string>() {"Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    private List<string> _listOfQuestions = new List<string>() {"Why was this experience meaningful to you?", "Have you ever done anything like this before?",
    "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public ReflectingActivity(string activityName, string description, int duration): base(activityName, description, duration)
    {
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int rdIndex = rnd.Next(_listOfPrompts.Count);
        string prompt = _listOfPrompts[rdIndex];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int rdIndex = rnd.Next(_listOfQuestions.Count);
        string question = _listOfQuestions[rdIndex];
        return question;
    }
    
    public void DisplayPrompt(string prompt)
    {
        string input;
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"\n --- {prompt} --- "); 
        Console.Write("\nWhen you have something in mind press enter to continue.");
        input = Console.ReadLine();
        Console.WriteLine("\nNow ponder of each following questions as they related to this experience:"); 
        Console.Write("You may begin in: ");
        PauseCountdownShown(5); 
    }

    public void DisplayQuestions()
    {
        string response = "No";
        string choice = "proceed";
        List<string> listPromptQuestions = new List<string>();      // to stock the questions used 
        List<string> listPrompts = new List<string>();      // to stock the prompts used 

        //choose a prompt randomly, display it, and add it to the list listPrompts
        string prompt = GetRandomPrompt();
        DisplayPrompt(prompt);
        listPrompts.Add(prompt);

        DateTime startTime = DateTime.Now;
        double time = GetDuration();
        DateTime futureTime = startTime.AddSeconds(time);       //for the duration of the activity
        DateTime currentTime = DateTime.Now;
        
        //the loop for the duration of the activity     
        while ((currentTime < futureTime) && (choice == "proceed"))
        {
            //choose a question randomly
            string quest = GetRandomQuestion();
            if (listPromptQuestions.Contains(quest) == false)       // to act if it is a different question
            {
            Console.Write($"\n{quest}");
            PauseSpinnerShown(625, 4);
            listPromptQuestions.Add(quest);
            }
            else if (listPromptQuestions.Count() == _listOfQuestions.Count()) // if there is no more questions 
            {
                Console.Write("\nThere are no more questions\n");
                Console.WriteLine("\nDo you want another prompt?(Yes or No) ");
                response = Console.ReadLine();

                if (response.ToLower() == "no")
                {
                    choice = "finish";
                }
                else 
                {
                    string newPrompt = GetRandomPrompt();
                    if (newPrompt != prompt)        //to have a different prompt
                    {
                        DisplayPrompt(newPrompt);
                        listPrompts.Add(newPrompt);
                        listPromptQuestions.Clear(); 
                    }
                }
            }
            else
            {
                while (listPromptQuestions.Contains(quest) == true)     //to have a question different
                {
                    quest = GetRandomQuestion();
                }
                Console.Write($"\n{quest}");
                PauseSpinnerShown(625, 4);
                listPromptQuestions.Add(quest);
            }
            currentTime = DateTime.Now; 
        }
        Console.WriteLine(" ");
    }

    public void RunActivity()
    {
        DisplayStartingMessage();
        DisplayQuestions();
        DisplayEndingMessage();
    }
}