using System;
using System.IO;
using System.Text.RegularExpressions;
public class Scripture
{
    private Reference _ref;
    private string _text;

    public Scripture(Reference reference, string text)
    {
        _ref = reference;
        _text = text;
    }

    public Reference GetRef()
    {
        return _ref;
    }
    public void SetReference( Reference reference)
    {
        _ref = reference;
    }

    public string GetText()
    {
        return _text;
    }
    public void SetText( string text)
    {
        _text = text;
    }

    
    public string GetScripture()
    {
        return _ref.GetReference() + " " + _text;
    }

    private List<string> _listOfWords = new List<string>(); 

   public List<string> GetListOfWords()
    { 
        string[] words = _text.Split(" ");     // give all the words of the text by index 
        foreach(string word in words)
        {
            _listOfWords.Add(word);          //list of words with all the words of the text in order 
        }
        return _listOfWords;
    }

    public string RandWord()
    {
        GetListOfWords();
        Random rnd = new Random();
        int randIndex = rnd.Next(_listOfWords.Count);      //choose an index from the list randomly
        string randWord = _listOfWords[randIndex];
        return randWord;                                   //return the random word chosing inside the words of the text
    }

    public string NewText(string word, string hideWord)
    {
        string newtext = _text.Replace(word, hideWord);      //replace the random word with the hide word inside the text
        return newtext;
    }

    public string NewScripture(string word, string hideWord)
    {
        return _ref.GetReference() + " " + NewText(word, hideWord);
    }
}

   