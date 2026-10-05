using System.Net;
using System.Reflection.Metadata.Ecma335;

class Menu
{
    Journal _journal = new Journal();

    /// <summary>
    /// A utility method to dispaly menu options for the user to select what action they want to
    /// perform with in the program.
    /// </summary>
    /// <returns>A boolean to tell the program in Main to stop or continue running.</returns>
    public bool DisplayMenu()
    {
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Dispaly");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.WriteLine("What would you like to do?");
        
        string response = Console.ReadLine();
        int parsedResponse = int.Parse(response);

        return this.ProcessUserInput(parsedResponse);
    }

    public bool ProcessUserInput(int response)
    {
        if (response == 1)
        {
            this._journal.WriteJournalEntry();
        } 
        else if (response == 2) {
            this._journal.DisplayEntries();
        }
        else if (response == 3)
        {
            
        }
        else if (response == 4)
        {
            
        }
        else if (response == 5)
        {
            Console.WriteLine("Are you sure you want to quit? (y/n)");
            string answer = Console.ReadLine();

            return answer == "y";
        } 
        else
        {
            
        }

        return false;
    }
}