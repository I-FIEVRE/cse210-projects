using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);

        //Displays the message, "Welcome to the Program!"
        static void DisplayWelcome()
        {
            Console.WriteLine("Hello world!Welcome to the Program!");
        }

        //Asks for and returns the user's name (as a string)
        static string PromptUserName()
        {
             Console.Write("Please enter your name: ");
             string userName = Console.ReadLine();
             return userName;     
        }

        //Asks for and returns the user's favorite number (as an integer)
         static int PromptUserNumber()
        {
             Console.Write("Please enter your favorite number: ");
             string input = Console.ReadLine();
             int userNumber = int.Parse(input);
             return userNumber;     
        }

        //Accepts an integer as a parameter and returns that number squared (as an integer)
        static int SquareNumber(int num)
        {
            int squareNum = num * num;
            return squareNum;
        }

        //Accepts the user's name and the squared number and displays them.
        static void DisplayResult(string name, int number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }



    }
}