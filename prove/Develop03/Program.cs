using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input;
        string choice = "proceed";

        List<string> ref1 = new List<string>(){"Proverbs", "3", "5", "-6"};
        List<string> ref2 = new List<string>(){"Proverbs", "3", "5", ""};
        List<string> ref3 = new List<string>(){"Mosiah", "5", "2", ""};
        List<string> ref4 = new List<string>(){"John", "14", "6", ""};
        List<string> ref5 = new List<string>(){"John", "6", "68", "-69"};

        List<List<string>> listOfListsOfRef = new List<List<string>>();
        listOfListsOfRef.Add(ref1);
        listOfListsOfRef.Add(ref2);
        listOfListsOfRef.Add(ref3);
        listOfListsOfRef.Add(ref4);
        listOfListsOfRef.Add(ref5);

        List<string> listOfScr = new List<string>() {"Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.", "Trust in the Lord with all thine heart; and lean not unto thine own understanding.", "And they all cried with one voice, saying: Yea, we believe all the words which thou hast spoken unto us; and also, we know of their surety and truth, because of the Spirit of the Lord Omnipotent, which has wrought a mighty change in us, or in our hearts, that we have no more disposition to do evil, but to do good continually.", "Jesus saith unto him, I am the way, the truth, and the life: no man cometh unto the Father, but by me.", "Then Simon Peter answered him, Lord, to whom shall we go? thou hast the words of eternal life. And we believe and are sure that thou art that Christ, the Son of the living God."};
    
        //choose a scripture randomly
        Random rand = new Random();
        int rdIndex = rand.Next(listOfScr.Count);
        int nbrOfRef = listOfListsOfRef[rdIndex].Count;

        Reference r1 = new Reference(listOfListsOfRef[rdIndex][0], listOfListsOfRef[rdIndex][1], listOfListsOfRef[rdIndex][2], listOfListsOfRef[rdIndex][3]);
        Scripture scr1 = new Scripture(r1, listOfScr[rdIndex]);  

        //display the scripture with the reference
        Console.WriteLine(scr1.GetScripture());
        
        // dispaly the choice of the user 
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        input = Console.ReadLine();

        //the word chosen randomly from the scripture
        Word wrd1 = new Word(scr1.RandWord());

        // the do - while loop 
        do 
        {
            if (input.ToUpper() == "QUIT")
            {
                choice = "finish";
            }
            else
            {
                Console.Clear();
                
                //the number of words to hide is choosing randomly
                Random rd = new Random();
                int nbr = rd.Next(2, 4);    

                for (int i = 0; i < nbr; i++) 
                {
                    scr1 = new Scripture(r1, scr1.NewText(wrd1.GetWord(), wrd1.HideWord()));
                    wrd1 = new Word(scr1.RandWord());
                }

                //display the scripture with the hide words chosen randomly
                Console.WriteLine(scr1.NewScripture(wrd1.GetWord(), wrd1.HideWord()));
                //dispaly the choice of the user
                Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
                input = Console.ReadLine();  
            }
        }
        //finish the loop when the scripture contains only whites space and underscores or when 'quit' is written
        while (Regex.IsMatch(scr1.NewText(wrd1.GetWord(), wrd1.HideWord()), "[a-zA-Z]") && choice == "proceed");
        
        //2 ways of ending the program
        if (input.ToUpper() == "QUIT")
        {
            Console.Clear();
            Console.WriteLine("Good bye!");
        } 
        else 
        {
            Console.Clear();
            Console.WriteLine("No more words to hide.\n");
        }          
    }
}