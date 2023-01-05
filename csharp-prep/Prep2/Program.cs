using System;

class Program
{
    static void Main(string[] args)
    {

        // ask the grade
        Console.Write("What is your grade (in %)? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        // create a variable letter
        char letter = ' ';

        // set the variable letter to the appropriate value
        if (grade < 60)
        {
            letter = 'F'; 
        }    
        else if (grade >= 60 && grade < 70)
        {   
            letter = 'D';
        }    
        else if (grade >= 70 && grade < 80)
        {
            letter = 'C';
        }    
        else if (grade >= 80 && grade < 90)
        {
            letter = 'B';
        }
        else
        {
            letter = 'A';
        }  

        // display the letter grade with the appropriate sign
        if (grade % 10 < 3 && letter != 'F')
        {
            Console.WriteLine($"you have {letter}-.");
        }    
        else if (grade % 10 >= 7 && letter != 'A' && letter != 'F')
        {
            Console.WriteLine($"you have {letter}+.");
        }    
        else
        {
            Console.WriteLine($"You have a {letter}." );
        }    

        // display if the user passed the course or not
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }    
        else
        {
            Console.WriteLine("We are sorry to inform you that you failed. You will do better the next time.");
        }       
        
    }
}