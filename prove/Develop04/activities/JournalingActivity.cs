class JournalingActivity : PromptActivity
{
    
    
    public JournalingActivity(string title, string description) : base(title, description)
    {
        this._prompts =
        [
            "What is something you are grateful for?",
            "What made you smile today?",
            "What did you do to serve someone today?",
            "How did you see God's hand in your life today?"
        ];
    }

    public override void RunActivity(Menu menu)
    {
        this.DisplayPromptActivityInstructions("In your journal, write a response to the following question: ");

        this.DisplayCountdownMessage("You may begin in: ", 3, false);

        Thread.Sleep(1000 * this.GetDuration());

        this.FinishActivity(menu);
    }
}