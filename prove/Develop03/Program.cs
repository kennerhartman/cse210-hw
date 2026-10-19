using System;

class Program
{
    const string text = """
    And he gathereth his children from the four quarters of the earth; and he numbereth his sheep, and they know him; and there shall be one fold and one shepherd; and he shall feed his sheep, and in him they shall find pasture.

    And because of the righteousness of his people, Satan has no power; wherefore, he cannot be loosed for the space of many years; for he hath no power over the hearts of the people, for they dwell in righteousness, and the Holy One of Israel reigneth.
    """;

    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(text, new ScriptureReference("1 Nephi", 22, 25, 26));

        scripture.DisplayScriptureWithReference();

        while (true)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                scripture.ScrambleWords();
            }
        }
    }
}