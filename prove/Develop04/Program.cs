using System;

class Program
{
    static void Main(string[] args)
    {
       
        string userChoice = "";
        
        int duration = 0;
        string breathing = "This activity will help you to relax by walking your through breathing in and out slowly. \nClear your mind and focus on your breathing.";
        string reflecting = "This activity will help you to reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.";
        string listing = "This activity will help you to reflect on the good things in your life by having you list as many things as you can in a certain area.";
        
        BreathingActivity a1 = new BreathingActivity("Breathing Activity", breathing, duration);
        ReflectingActivity a2 = new ReflectingActivity("Reflecting Activity", reflecting, duration);
        ListingActivity a3 = new ListingActivity("Listing Activity", listing, duration);
        
        do // loop to pursue until 4 is given by the user
        {
            // menu appears each time 
            Console.WriteLine("\nMenu Options: \n 1. Start breathing activity \n 2. Start reflecting activity \n 3. Start listing activity \n 4. Quit");
            Console.WriteLine("Select a choice from the menu: ");
            // the choice of the user 
            userChoice = Console.ReadLine();
        
            if (userChoice == "1")      //breathing activity
            {
                a1.RunActivity();
            }
            else if (userChoice == "2")     //reflecting activity
            {
                a2.RunActivity();
            }
            else if (userChoice == "3")     //listing activity
            {
                a3.RunActivity();
            }
            else if (userChoice == "4")     //quit
            {
                Console.WriteLine("Good Bye!\n"); 
            }
             else
            { // help when another word or character is written by the user
                Console.WriteLine("You have to choose between 1, 2, 3, or 4"); 
            }
        } while (!(userChoice == "4"));       
    }

}