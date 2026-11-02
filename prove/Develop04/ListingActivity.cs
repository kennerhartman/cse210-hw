class ListingActivity : PromptActivity 
{
    private List<string> _userResponses = new List<string>();
    
    public ListingActivity(string title, string description) : base(title, description)
    {
        this._prompts = [
            "When have you felt the Holy Ghost this month?",
            "What are personal strengths of yours?",
            "Who are people that you appreciate?",
            "What activities/hobbies do you enjoy to do?"
        ];
    }

    public void RunActivity()
    {
        this.DisplayPromptActivityInstructions("List as many responses you can to the following prompt:");

        this.DisplayCountdownMessage("You may begin in: ", 3, false);

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
}