abstract class PromptActivity : Activity
{
    private Random _random = new Random();
    protected string[] _prompts;
    
    public PromptActivity(string title, string description) : base(title, description)
    {
    }

    public void DisplayPromptActivityInstructions(string instructions)
    {
        Console.WriteLine($"{instructions}\n");
        
        string prompt = this.GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---\n");
    }

    private string GetRandomPrompt()
    {
        int length = this._prompts.Count();
        
        if (length == 0)
        {
            return "";
        }

        return this._prompts[this._random.Next(length)];
    }
}