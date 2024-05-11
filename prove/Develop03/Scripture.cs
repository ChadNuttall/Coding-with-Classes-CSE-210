using System;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Seperate each word from the text and add it to Word list
        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        // Hide random words until the desired number of words or all words are hidden
        while (numberToHide > 0 && _words.Any(word => !word.IsHidden()))
        {
            int randomIndex = random.Next(0, _words.Count); // Generate a random index to select a word from the list
            if (!_words[randomIndex].IsHidden()) // Check if the random word selected is not already hidden
            {
                _words[randomIndex].Hide(); // Hide the selected word
                numberToHide--; // Decrease the number of words left to hide
            }
        }
    }

    public string GetDisplayText()
    {
        List<string> displayText = new List<string>();
        // Display all words in the Word list
        foreach (Word word in _words)
        {
            displayText.Add(word.GetDisplayText());
        }
        // Add a space between each word
        return string.Join(" ", displayText);
    }

    public bool IsCompletelyHidden()
    {
        // determine if all words in Word list are hidden
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}