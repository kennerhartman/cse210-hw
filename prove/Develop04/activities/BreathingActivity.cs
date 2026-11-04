class BreathingActivty : Activity 
{
    public BreathingActivty(string title, string description) : base(title, description)
    {
    }

    public override void RunActivity(Menu menu)
    {
        int duration = this.GetDuration();
        
        DateTime endTime = DateTime.Now.AddSeconds(duration);

        int actualDuration = 0;
        
        bool breathingIn = true;
        bool shouldContinueLoop = DateTime.Now < endTime;

        while (shouldContinueLoop)
        {
            bool stillNeedsToBreathOut;

            if (breathingIn)
            {
                this.DisplayCountdownMessage("Breath in... ", 4, false);
                stillNeedsToBreathOut = true;
                actualDuration += 4;
            }
            else
            {
                this.DisplayCountdownMessage("Breath out... ", 6, false);
                
                stillNeedsToBreathOut = false;
                actualDuration += 6;

                if (DateTime.Now < endTime)
                {
                    Console.WriteLine();
                }
            }

            shouldContinueLoop = DateTime.Now < endTime || stillNeedsToBreathOut;
            breathingIn = !breathingIn;
        }

        this.FinishActivity(menu, actualDuration);
    }
}