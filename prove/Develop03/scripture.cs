using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _verseReference;
    private List<Word> _textAsWords;

    public Scripture(Reference verseReference, string text)
    {
        _verseReference = verseReference;
        _textAsWords = StringToWord(text);
    }

    private List<Word> StringToWord(string text)
    {
        List<Word> words = new List<Word>();

        string[] splitWords = text.Split(" ");

        foreach (string word in splitWords)
        {
            words.Add(new Word(word));
        }

        return words;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_verseReference.GetReference());

        foreach (Word word in _textAsWords)
        {
            Console.Write(word.GetDisplayText() + " ");
        }

        Console.WriteLine();
    }

    public void HideWords()
    {
        Random random = new Random();

        int hiddenCount = 0;

        while (hiddenCount < 3)
        {
            int index = random.Next(_textAsWords.Count);

            if (!_textAsWords[index].IsHidden())
            {
                _textAsWords[index].Hide();
                hiddenCount++;
            }

            if (AllWordsHidden())
            {
                break;
            }
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _textAsWords)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}