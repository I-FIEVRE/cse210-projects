using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "lost";

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //Console.Write("What is the magic number? ");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);

        string input;
        do
        {
             Console.Write("What is your guess? ");
             input = Console.ReadLine();
             int userGuess = int.Parse(input);
            if (userGuess > magicNumber) 
            {
                Console.WriteLine("Lower");
            } 
            else if (userGuess < magicNumber) 
            {
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You guessed it!");
                choice = "win";
            }
        } while (choice == "lost");
       
    }
}    