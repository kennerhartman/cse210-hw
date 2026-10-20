class ScriptureReference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _finalVerse; // -1 == no second or end verse

    public ScriptureReference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._finalVerse = -1;
    }

    public ScriptureReference(string book, int chapter, int verse, int finalVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._finalVerse = finalVerse;
    }

    public void DisplayReference()
    {
        Console.WriteLine(this.AsString());
    }

    public string AsString()
    {
        string finalVerse = this._finalVerse == -1 ? "" : $"-{this._finalVerse}";

        return $"{this._book} {this._chapter}:{_verse}{finalVerse}";
    }
}