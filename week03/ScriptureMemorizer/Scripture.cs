using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _random = new Random();

        string[] splitWords = text.Split(' ');

        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Collect only words that are still visible
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        int hidden = 0;

        // Randomly hide only visible words
        while (hidden < numberToHide && visibleIndexes.Count > 0)
        {
            int randomIndex = _random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];

            _words[wordIndex].Hide();

            visibleIndexes.RemoveAt(randomIndex);
            hidden++;
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            result += word.GetDisplayText() + " ";
        }

        return result.Trim();
    }
}