using System.Globalization;

class Menu
{
    private static char delimiter = '|';

    Journal _journal = new Journal();

    /// <summary>
    /// A utility method to dispaly menu options for the user to select what action they want to
    /// perform within the program.
    /// </summary>
    /// <returns>A boolean to tell the program in Main to stop or continue running.</returns>
    public bool DisplayMenu()
    {
        Console.WriteLine("What would you like to do?");
        
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Dispaly");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
        string response = Console.ReadLine();

        if (int.TryParse(response, out int option))
        {
            return this.ProcessUserInput(option);
        } 
        else
        {
            Console.WriteLine($"'{response}' is not a valid option!\n");
        }

        return false;
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
            this.LoadJournal();
        }
        else if (response == 4)
        {
            this.SaveJournal();
        }
        else if (response == 5)
        {
            Console.WriteLine("Are you sure you want to quit? (y/n)");
            string answer = Console.ReadLine();

            return answer == "y";
        } 
        else
        {
            Console.WriteLine("Could not find a valid action to take.");
        }

        return false;
    }

    public void SaveJournal()
    {
        Console.Write("Please enter the filename: ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        List<string> lines = [];

        foreach (Entry entry in this._journal._entries)
        {
            string line = $"{entry._date}{Menu.delimiter}{entry._prompt}{Menu.delimiter}{entry._response}";

            lines.Add(line);
        }

        if (File.Exists(filename))
        {
            Console.Write("This file already exists. Do you want to overwrite it? (y/n)");
            string response = Console.ReadLine();

            if (response == "y")
            {
                File.WriteAllLines(filename, lines);
            }
        }
    }

    public void LoadJournal()
    {
        Console.Write("Please enter the filename to load: ");
        string filename = Console.ReadLine();

        if (!filename.EndsWith(".txt"))
        {
            filename += ".txt";
        }

        if (!File.Exists(filename))
        {
            Console.WriteLine($"Could not find file with name {filename}.\n");
            
            return;
        }

        List<string> lines = File.ReadAllLines(filename).ToList();

        foreach (string line in lines)
        {
            string[] parts = line.Split(Menu.delimiter);

            string dateString = parts[0];
            string prompt = parts[1];
            string response = parts[2];

            string dateFormat = "M/d/yyyy h:mm:ss tt";
            string cleanedDateString = dateString.Replace('\u202F', ' ');
            DateTime date = DateTime.ParseExact(cleanedDateString, dateFormat, CultureInfo.InvariantCulture);

            Entry entry = new Entry(date, prompt, response);

            this._journal.AddEntry(entry);
        }
    }
}