using Helper.UserInputHelper;

namespace D11kader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string textToDisplay = UserInput.StringInput("What text do you wanna see in a border? ");
            DisplayInBorder(textToDisplay);
        }

        static void DisplayInBorder(string output)
        {

            int len = output.Length;
            string fullLine = new string('*', len + 4);
            string textLine = $"* {output} *";

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(fullLine);
            Console.WriteLine(textLine);
            Console.WriteLine(fullLine);
        }
    }
}
