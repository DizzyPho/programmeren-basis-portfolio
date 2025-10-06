using Helper.UserInputHelper;

namespace D07zoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ").ToLower();
            string search = UserInput.StringInput("Give a piece of text to search for: ").ToLower();

            int timesFound = 0;
        }
    }
}
