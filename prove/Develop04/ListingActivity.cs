class ListingActivity : Activity 
{
    private string[] _prompts =
    {
        "When have you felt the Holy Ghost this month?",
        "What are personal strengths of yours?",
        "Who are people that you appreciate?",
        "What activities/hobbies do you enjoy to do?"
    };

    private List<string> _userResponses = new List<string>();
    
    public ListingActivity(string title, string description) : base(title, description)
    {
    }

    public void RunActivity()
    {
        // TODO: MOVE TO A METHOD IN A NEW 'PromptActivity' CLASS

        Console.WriteLine("List as many responses you can to the following prompt:");

        string prompt = this.GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---\n");

        this.DisplayCountdownMessage("You may begin in", 3);

        int duration = this.GetDuration();
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                continue;
            }

            this._userResponses.Add(input);
        }

        Console.WriteLine($"You listed {this._userResponses.Count()} items!");

        this.DisplayEndingMessage();
    }

    // TODO: MOVE TO A METHOD IN A NEW 'PromptActivity' CLASS
    private string GetRandomPrompt()
    {
        Random random = new Random();
        
        int length = this._prompts.Count();

        return this._prompts[random.Next(length)];
    }
}