class Scripture
{
    private List<Word> _words = [];
    private ScriptureReference _reference;
    private Random _random = new Random();

    public Scripture(string text, ScriptureReference reference)
    {
        this._reference = reference;

        this.SeperateWords(text);
    }

    public string GetReference()
    {
        return this._reference.AsString();
    }

    public void DisplayScriptureWithReference()
    {
        Console.Clear();

        this._reference.DisplayReference();
        
        this.DisplayWords();
    }

    public void ScrambleWords(int numberOfWordsToHide)
    {
        Console.Clear();
        
        this.HideWords(numberOfWordsToHide);
    }

    public void ResetScripture()
    {
        foreach (Word word in this._words)
        {
            word.RevealWord();
        }
    }

    private void SeperateWords(string text)
    {
        string[] seperators = { "\r\n", "\n" };
        string[] lines = text.Split(seperators, StringSplitOptions.None);

        for (int i = 0; i < lines.Length; ++i)
        {
            string[] words = lines[i].Split([' '], StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in words)
            {
                this._words.Add(new Word(word));
            }

            if (i < lines.Length - 1)
            {
                this._words.Add(new Word("\n"));
            }
        }
    }

    private void HideWords(int numberOfWordsToHide)
    {
        if (numberOfWordsToHide <= 0)
        {
            numberOfWordsToHide = 3;
        }

        int wordsHidden = 0;

        while (wordsHidden < numberOfWordsToHide && this._words.Any(word => !word.IsHidden() && word.AsString() != "\n"))
        {
            int i = this._random.Next(this._words.Count);
            
            Word word = this._words[i];

            if (word.IsHidden() || word.AsString() == "\n")
            {
                continue;
            } else
            {
                word.HideWord();
                ++wordsHidden;
            }
        }
    }

    private void DisplayWords()
    {
        foreach (Word word in this._words)
        {
            if (word.AsString() == "\n")
            {
                Console.Write(word.AsString());
            }
            else
            {
                Console.Write(word.AsString() + " ");
            }
        }

        Console.WriteLine();
    }
}