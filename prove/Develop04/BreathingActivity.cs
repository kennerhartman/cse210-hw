class BreathingActivty : Activity 
{
    public BreathingActivty(string title, string description) : base(title, description)
    {
    }

    public void RunActivity()
    {
        DateTime endTime = DateTime.Now.AddSeconds(this.GetDuration());

        bool breathingIn = true;
        bool shouldContinueLoop = DateTime.Now < endTime;

        while (shouldContinueLoop)
        {
            bool stillNeedsToBreathOut;
            
            if (breathingIn)
            {
                this.DisplayCountdownMessage("Breath in... ", 4, false);
                stillNeedsToBreathOut = true;
            }
            else
            {
                this.DisplayCountdownMessage("Breath out... ", 6, false);
                stillNeedsToBreathOut = false;

                if (DateTime.Now < endTime)
                {
                    Console.WriteLine();
                }
            }

            shouldContinueLoop = DateTime.Now < endTime || stillNeedsToBreathOut;
            breathingIn = !breathingIn;
        }

        this.DisplayEndingMessage();
    }
}