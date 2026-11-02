class ReflectingActivity : PromptActivity 
{
    private string[] _questions = {
       "Think of a time when you did something really difficult.",
       "Think of a time when you did something exciting with friends.",
       "Think of a time when you stood up for someone else.",
       "Think of a time when you did something really difficult.",
    };
    
    public ReflectingActivity(string title, string description) : base(title, description)
    {
        this._prompts = [
            "Think of a time when you did something really difficult.",
            "Think of a time when you did something exciting with friends.",
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
        ];
    }

    public void RunActivity()
    {
        this.DisplayPromptActivityInstructions("Consider the following prompt:");

        Console.WriteLine("When you have something in mind, press 'enter' to continue.");

        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            this.DisplayCountdownMessage("You may begin in: ", 3);
            
            Console.Clear();

            int durationPerQuestion = this.GetDuration() / 2;

            this.DisplaySpinnerMessage($"> {this.GetRandomQuestion()}", durationPerQuestion, false);
            this.DisplaySpinnerMessage($"> {this.GetRandomQuestion()}", durationPerQuestion, false);

            this.DisplayEndingMessage();
        }
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        
        int length = this._questions.Count();

        return this._questions[random.Next(length)];
    }
}