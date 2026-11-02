using System;

class Program
{
    // TODO: IMPLEMENT A MENU
    // TODO: KEEP TRACK OF THE TOTAL TIME THE USER HAS DONE MINDFULLNESS ACTIVITIES

    static void Main(string[] args)
    {
        RunBreathingActivity();
        // RunListingActivity();
    }

    private static void RunBreathingActivity()
    {
        BreathingActivty breathingActivty = new BreathingActivty("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mi nd and focus on your breathing.");

        breathingActivty.DisplayStartingMessage();
        breathingActivty.GetDurationFromUser();
        breathingActivty.DisplaySpinnerMessage("Get ready...", 3);
        breathingActivty.RunActivity();
    }

    private static void RunReflectingActivity()
    {
        ReflectingActivity reflectingActivity = new ReflectingActivity(
            "Reflecting Activity", 
            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
        );

        reflectingActivity.DisplayStartingMessage();
        reflectingActivity.GetDurationFromUser();
        reflectingActivity.DisplaySpinnerMessage("Get ready...", 3);
        reflectingActivity.RunActivity();
    }

    private static void RunListingActivity()
    {
        ListingActivity listingActivity = new ListingActivity(
            "Listing Activity", 
            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
        );

        listingActivity.DisplayStartingMessage();
        listingActivity.GetDurationFromUser();
        listingActivity.DisplaySpinnerMessage("Get ready...", 3);
        listingActivity.RunActivity();
    }
}