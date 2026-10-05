class Entry
{
    public string _response;
    public string _prompt;
    public DateTime _date;

    public Entry(string prompt, string response)
    {
        this._prompt = prompt;
        this._response = response;
        this._date = DateTime.Now;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"--- Entry for {this._date} ---");
        Console.WriteLine($"Prompt: {this._prompt}");
        Console.WriteLine($"Response: {this._response}\n");
    }
}