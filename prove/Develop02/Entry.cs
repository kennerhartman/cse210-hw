class Entry
{
    public string _response;
    public string _prompt;
    public DateTime _date;

    /// <summary>
    /// Create a new entry with a given date and time.  Useful for creating a new entry object
    /// from data laoded from a file.
    /// </summary>
    /// <param name="date"></param>
    /// <param name="prompt"></param>
    /// <param name="response"></param>
    public Entry(DateTime date, string prompt, string response)
    {
        this._date = date;
        this._prompt = prompt;
        this._response = response;
    }

    /// <summary>
    /// Create a new entry with the current date and time.
    /// </summary>
    /// <param name="prompt"></param>
    /// <param name="response"></param>
    public Entry(string prompt, string response)
    {
        this._date = DateTime.Now;
        this._prompt = prompt;
        this._response = response;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"--- Entry for {this._date} ---");
        Console.WriteLine($"Prompt: {this._prompt}");
        Console.WriteLine($"Response: {this._response}\n");
    }
}