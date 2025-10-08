using Helper.UserInputHelper;

namespace D09morse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] morse = { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            string input = string.Empty;
            string decoded = string.Empty;

            while (true) {

                input = UserInput.StringInput("Input morse code for the next letter: ").Trim();

                if (input == "/") {
                    break;
                }
                
                int morseIndex = Array.IndexOf(morse, input);

                if (morseIndex == -1)
                {
                    Console.WriteLine("Invalid morse code.");
                    continue;
                }
            }
        }
    }
}
