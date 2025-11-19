using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(" ");
        foreach (string wrd in splitWords)
        {
            _words.Add(new Word(wrd));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        for(int i =0; i < numberToHide; i++)
        {
            int index = rand.Next(_words.Count);
            _words[index].Hide();
        }
    }
public string GetDisplayText()
    {
        List<string>wordDisplay = new List<string>();

        foreach(Word wrd in _words)
        {
            wordDisplay.Add(wrd.GetDisplayText());
        }

        return $"{_reference.GetDisplayText()}\n\n{string.Join(" ", wordDisplay)}";
    }

    public bool IsCompletelyHidden()
    {
        foreach(Word wrd in _words)
        {
            if(!wrd.IsHidden())
            return false;
        }
        return true;
    }
      
}