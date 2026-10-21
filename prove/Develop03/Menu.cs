class Menu
{
    private List<Scripture> _scriptures = new List<Scripture>();
    private int _numberOfWordsToHide = 3;
    private bool _isRunning = true;

    public Menu()
    {
        ScriptureReference moses139 = new ScriptureReference("Moses", 1, 39);
        ScriptureReference moses718 = new ScriptureReference("Moses", 7, 18);
        ScriptureReference malachi3810 = new ScriptureReference("Malachi", 3, 8,  10);
        ScriptureReference mosiah319 =  new ScriptureReference("Mosiah", 3, 19);
        
        this._scriptures.Add(
            new Scripture(
                "This is my work and my glory—to bring to pass the immortality and eternal life of man.",
                moses139
            )
        );

        this._scriptures.Add(
            new Scripture(
                "This is my work and my glory—to bring to pass the immortality and eternal life of man.",
                moses718
            )
        );

        this._scriptures.Add(
            new Scripture(
                """
                Will a man rob God? Yet ye have robbed me. But ye say, Wherein have we robbed thee? In tithes and offerings.
                
                Ye are cursed with a curse: for ye have robbed me, even this whole nation.

                Bring ye all the tithes into the storehouse, that there may be meat in mine house, and prove me now herewith, saith the Lord of hosts, if I will not open you the windows of heaven, and pour you out a blessing, that there shall not be room enough to receive it.
                """,
                malachi3810
            )
        );

        this._scriptures.Add(
            new Scripture(
               """
               For the natural man is an enemy to God, and has been from the fall of Adam, and will be, forever and ever, unless he yields to the enticings of the Holy Spirit, and putteth off the natural man and becometh a saint through the atonement of Christ the Lord, and becometh as a child, submissive, meek, humble, patient, full of love, willing to submit to all things which the Lord seeth fit to inflict upon him, even as a child doth submit to his father.
               """,
                mosiah319
            )
        );

        Console.WriteLine("How many words do you want to hide?");
        
        string wordsToHideInput = Console.ReadLine();
        this._numberOfWordsToHide = int.Parse(wordsToHideInput);
        Console.Clear();
    }

    public void DisplayMenu()
    {
        for (int i = 0; i < this._scriptures.Count; ++i)
        {
            Console.WriteLine($"{i + 1}. {this._scriptures[i].GetReference()}");
        }

        Console.WriteLine($"{this._scriptures.Count + 1}. Quit");

        string userInput = Console.ReadLine();
        int inputAsInt = int.Parse(userInput) - 1;

        this.HandleUserInput(inputAsInt);
    }

    private void HandleUserInput(int input)
    {
        if (input >= 0 && input < this._scriptures.Count)
        {
            this.DisplayScripture(input);
        }
        else if (input == this._scriptures.Count)
        {
            this._isRunning = false;
        } else
        {
            Console.WriteLine($"'{input + 1}' is not a valid option!\n");
        }
    }

    private void DisplayScripture(int scriptureIndex)
    {
        bool isDisplayingScripture = true;

        while (isDisplayingScripture)
        {
            Scripture scripture = this._scriptures[scriptureIndex];

            scripture.DisplayScriptureWithReference();

            Console.WriteLine("\nPress 'Enter' to hide words or 'q' to exit.");

            string key = Console.ReadLine();

            if (string.IsNullOrEmpty(key))
            {
                scripture.ScrambleWords(this._numberOfWordsToHide);
            }
            else if (key == "q")
            {
                Console.Clear();
                
                isDisplayingScripture = false;

                scripture.ResetScripture();
            }
        }
    }

    public bool IsRunning()
    {
        return this._isRunning;
    }
}