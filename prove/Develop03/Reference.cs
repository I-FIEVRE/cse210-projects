using System;
using System.IO;
public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _endVerse;

    public  Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    } 

    public Reference( string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetBook()
    {
        return _book;
    }
    public void SetBook(string book)
    {
        _book = book;
    }

    public string GetChapter()
    {
        return _chapter;
    }
    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string GetVerse()
    {
        return _verse;
    }
    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string GetEndVerse()
    {
        return _endVerse;
    }
    public void SetEndVerse(string endVerse)
    {
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_endVerse != null )
    {
        return _book + " " + _chapter + ":" + _verse +  _endVerse;
    } 
    else
    {
        return _book + " " + _chapter + ":" + _verse;
    }
    }
    
}