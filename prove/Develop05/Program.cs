using System;

// Creativity :
//class named BadHabit for bad habits with the choice of the points lost and of the malus after a number of times chosen by the user
//special congratulations for the bonus 
//little change in the design
class Program
{   
    static void Main(string[] args)
    {
        string userChoice = "";
        List<string> entriesOfGoals = new List<string>();
        int score = 0;

        SimpleGoal sg1 = new SimpleGoal("", "", 0);
        EternalGoal eg1 = new EternalGoal("", "", 0);
        CheckListGoal clg1 = new CheckListGoal("", "", 0, 0, 0, 0);
        BadHabit bh1 = new BadHabit("", "", 0, 0, 0, 0);

        do // loop to pursue until 6 is given by the user
        { 
            // menu appears each time 
            Console.WriteLine($"You have {score} points.");
            Console.WriteLine("\nMenu Options: \n 1. Create a new goal \n 2. List Goals \n 3. Save Goals \n 4. Load Goals \n 5. Record Event \n 6: Quit");
            Console.WriteLine("Select a choice from the menu: ");
            // the choice of the user 
            userChoice = Console.ReadLine();

            if (userChoice == "1")      //Create a new goal
            {
                string user2Choice = "";
                // menu
                Console.WriteLine("\nThe type of goals are:\n 1. Simple Goal \n 2. Eternal Goal \n 3. Checklist Goal \n 4. Bad Habit");
                Console.WriteLine("Wich type of goal do you like to create? ");
                // the choice of the user 
                user2Choice = Console.ReadLine();

                if (user2Choice == "1")      //Create a new simple goal
                {
                    sg1.MessageGoal("Simple Goal");
                    entriesOfGoals.Add(sg1.CreateGoal());
                    Console.WriteLine("");
                }
                else if (user2Choice == "2")        //Create a new eternal goal
                {
                    eg1.MessageGoal("Eternal Goal");
                    entriesOfGoals.Add(eg1.CreateGoal());
                    Console.WriteLine("");
                }
                else if (user2Choice == "3")        //Create a new checklist goal
                {
                    clg1.MessageGoal("Checklist Goal");
                    clg1.NextMessageGoal();
                    entriesOfGoals.Add(clg1.CreateGoal());
                    Console.WriteLine("");
                }
                 else if (user2Choice == "4")        //Create a new bad habit
                {
                    bh1.MessageGoal("Bad Habit");
                    bh1.NextMessage();
                    entriesOfGoals.Add(bh1.CreateGoal());
                    Console.WriteLine("");
                }
            }
            else if (userChoice == "2")     //List Goals
            {
                Display d = new Display();
                d.DisplayListOfGoals(entriesOfGoals);
            }
            else if (userChoice == "3")     //Save Goals
            {
                Save s = new Save();
                s.SaveGoals(entriesOfGoals, score);
            }
             else if (userChoice == "4")     //Load Goals
            {
                Console.WriteLine("What is the filename? ");
                string userFileName = Console.ReadLine();  
                Load l = new Load();
                l.LoadGoals(entriesOfGoals, userFileName);
                int sc= l.ReturnScore(entriesOfGoals, userFileName);
                SimpleGoal g = new SimpleGoal ("", "", 0); 
                g.SetScore(sc);
                score = g.GetScore();
            }
            else if (userChoice == "5")     //Record Event
            {
                Display d1 = new Display();
                d1.DisplayListOfGoals2(entriesOfGoals);
                Console.WriteLine("Wich goal did you accomplish? ");
                // the choice of the user 
                string user3Choice = Console.ReadLine();
                int n = int.Parse(user3Choice);
                string goal = entriesOfGoals[n - 1];
                
                string lGoal =  d1.GetGoalDetailPart(goal);
                string[] items = lGoal.Split(", ");

                if (d1.GetKindGoalPart(goal) == "Simple goal")
                {
                    SimpleGoal sg = new SimpleGoal(items[0], items[1], int.Parse(items[2]));
                    entriesOfGoals[n - 1] = sg.RecordEvent(score);
                    score = sg.GetScore();   
                }
                else if (d1.GetKindGoalPart(goal) == "Eternal goal")
                { 
                    EternalGoal eg = new EternalGoal(items[0], items[1], int.Parse(items[2]));
                    entriesOfGoals[n - 1] = eg.RecordEvent(score);
                    score = eg.GetScore();  
                }
                else if (d1.GetKindGoalPart(goal) == "Checklist goal")
                { 
                    CheckListGoal cg = new CheckListGoal(items[0], items[1], int.Parse(items[2]), int.Parse(items[4]), int.Parse(items[3]), int.Parse(items[5]));
                    entriesOfGoals[n - 1] = cg.RecordEvent(score);
                    score = cg.GetScore();  
                } 
                else if (d1.GetKindGoalPart(goal) == "Bad habit")
                { 
                    BadHabit bh = new BadHabit(items[0], items[1], int.Parse(items[2]), int.Parse(items[4]), int.Parse(items[3]), int.Parse(items[5]));
                    entriesOfGoals[n - 1] = bh.RecordEvent(score);
                    score = bh.GetScore();  
                }   
            }
            else if (userChoice == "6")     //quit        
            {
                Console.WriteLine("Good Bye!\n"); 
            }
            else
            { // help when another word or character is written by the user
                Console.WriteLine("You have to choose between 1, 2, 3, 4, 5 or 6"); 
            }
        } while (!(userChoice == "6"));       
    }
}