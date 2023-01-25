using System;

public class PromptQuoteGenerator

{
    private List<string> _prompts = new List<string>();
    public string _randomPrompt;
    private List<string> _quotes = new List<string>();   
    public string _randomQuote;
    
    public void Generate()
      //Generate a prompt and a quote randomly
     {
          Random random = new Random();
          // add different prompts to the list of strings _prompts
          _prompts.Add("Who was the most interesting person I interacted with today? ");
          _prompts.Add("What was the best part of my day? ");
          _prompts.Add("How did I see the hand of the Lord in my life today? ");
          _prompts.Add("What was the strongest emotion I felt today? ");
          _prompts.Add("If I had one thing I could do over today, what would it be? ");
          _prompts.Add("What was a scripture that touched me today? ");
          _prompts.Add("What is a thing that I learned today? ");
          _prompts.Add("What is a thing that I did for others today? ");
          _prompts.Add("What is something good that I ate today? ");
          _prompts.Add("What is a thing that somebody did for me today? ");

          int indexPrompt = random.Next(_prompts.Count);
          _randomPrompt = _prompts[indexPrompt]; // _randomPrompt is the prompt chosen randomly

          // add different quotes to the list of strings _quotes
          _quotes.Add(" Ezra Taft Benson: When you choose to follow Christ, you choose to be changed. ");
          _quotes.Add(" Jeffrey R. Holland: I urge you to be peacemakers. To love peace. \n To seek peace. To create peace. ");
          _quotes.Add(" Linda K. Burton: Whe we work together in love and unity, we can expect heaven's help.");
          _quotes.Add(" Russell M. Nelson: When you know your life is being directed by God, \n regardless of the challenges and disappointments that may and \n will come, you will feel joy and peace. ");
          _quotes.Add(" Dieter F. Uchtdorf: He sees what we do not see. Trust in Him.");
          _quotes.Add(" Thomas S. Monson: For maximum happiness, peace, and contentment, \n may we choose a positive attitude.");
          _quotes.Add(" David A. Bednar: Ordinary people who faithfully, diligently and \n consistently do simple things that are right before God \n will bring forth extraordinary results. ");
          _quotes.Add(" Dieter F. Uchtdorf: Even when you are not at fault - \n perhaps especially when you arre not at fault - \n let LOVE conquer pride.");
          _quotes.Add(" Thomas S. Monson: Remember that  the Lord will shape \n to bearthe burden placed upon it.");
          _quotes.Add(" Joseph B: Wirthlin: We are faced with a choice. \n We can trust in our own strength, or we can \n journey to higher ground and come unto Christ.");

          int indexQuote = random.Next(_quotes.Count);
          _randomQuote = _quotes[indexQuote]; // _randomQuote is the quote chosen randomly         
     }
}




