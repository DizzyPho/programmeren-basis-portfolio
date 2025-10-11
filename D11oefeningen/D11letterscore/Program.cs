using Helper.UserInputHelper;

namespace D11letterscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int percent = UserInput.IntegerInput("Give your score as a percentage: ");
            char letterCode = GetLetterCode(percent);
            Console.WriteLine($"In America, that would be: {letterCode}");
        }

        static char GetLetterCode(int percentage) {

            char letter = percentage switch
            {
                > 82 => 'A',
                > 67 => 'B',
                > 52 => 'C',
                > 37 => 'D',
                > 22 => 'E',
                _ => 'F'
            };

            return letter;

        }
    }
}
