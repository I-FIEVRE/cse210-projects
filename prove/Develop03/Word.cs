using System;
using System.IO;

public class Word
{
    private string _word;
    private string _hideWord;

    public Word(string textWord)
    {
        _word = textWord;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
        _word = word;
    }

    public string HideWord()
    {
        _hideWord = new string ('_', _word.Length);
        return _hideWord;
    } 
}

