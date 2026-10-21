class Word
{
    private string _word;
    private bool _isHidden = false;

    public Word(string text)
    {
        this._word = text;
    }

    public bool IsHidden()
    {
        return this._isHidden;
    }

    public void HideWord()
    {
        char newChar = '_';

        char[] chars = this._word.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            chars[i] = newChar;
        }

        this._word = new string(chars);
        this._isHidden = true;
    }

    public string AsString()
    {
        return this._word;
    }
}