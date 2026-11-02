class BreathingActivty : Activity 
{
    public BreathingActivty(string title, string description) : base(title, description)
    {
    }

    public void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(this.GetDuration());

        bool breathingIn = true;

        while (DateTime.Now < endTime)
        {
            if (breathingIn)
            {
                this.DisplayCountdownMessage("Breath in... ", 4);
            } 
            else
            {
                this.DisplayCountdownMessage("Breath out... ", 6);    
            }

            breathingIn = !breathingIn;
        }

        this.DisplayEndingMessage();
    }
}