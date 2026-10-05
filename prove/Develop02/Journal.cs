using System.Runtime.InteropServices.Swift;

class Journal
{
    Random _random = new Random(); // used to get a random number to get a random prompt from _prompts.

    List<string> _prompts = [
        "What are you grateful for today?",
        "How did you see the hand of the Lord in your life today?",
        "What is something spontaneous you did today?",
        "What brought you joy today?",
        "What is something you want to do differently tomorrow from your experineces today?",
        "Write about your day; the ups and downs."
    ];

    public List<Entry> _entries = [];

    /// <summary>
    /// Add an entry to the journal from an already exisitng entry object.
    /// </summary>
    /// <param name="entry">The entry to add to the journal.</param>
    public void AddEntry(Entry entry)
    {
        this._entries.Add(entry);
    }

    /// <summary>
    /// Selects a random prompt to display to the user and gives the user the opportunity to write a journal entry. After they finsihed writing their response,
    /// a new Entry is created and stored in the _entries list.
    /// </summary>
    public void WriteJournalEntry()
    {
        string prompt = this._prompts[this._random.Next(this._prompts.Count())];

        Console.WriteLine($"Here is a prompt to give you ideas: {prompt}");
        Console.Write("> ");

        string response = Console.ReadLine();

        Entry entry = new Entry(prompt, response);
        Console.WriteLine(entry._date);

        this._entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in this._entries)
        {
            entry.DisplayEntry();
        }
    }
}