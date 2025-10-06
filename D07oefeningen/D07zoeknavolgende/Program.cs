using Helper.UserInputHelper;

namespace D07zoeknavolgende
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ").ToLower();
            string search = UserInput.StringInput("Give a piece of text to search for: ").ToLower();

            int timesFound = 0;
            int foundAtIndex = 0;
            int searchLength = search.Length;

            while (foundAtIndex != -1)
            {
                if (search == string.Empty)
                {
                    break;
                }

                foundAtIndex = text.IndexOf(search, foundAtIndex + searchLength - 1);

                if (foundAtIndex != -1)
                {
                    timesFound++;
                }
            }
            Console.WriteLine($"Found your search term {timesFound} times.");
        }
    }
}
