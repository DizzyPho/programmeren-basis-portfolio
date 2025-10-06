using Helper.UserInputHelper;

namespace D07medeklinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ");
            int vowelCounter = 0;
            int consCounter = 0;

            foreach (char c in text) {
                if (isVowel(c))
                {
                    vowelCounter++;
                }
                else if (isConsonant(c))
                {
                    consCounter++;
                } 
            }
            Console.WriteLine($"This text contains {vowelCounter} vowels and {consCounter} consonants.");
        }

        static bool isVowel(char c)
        {
            const string vowels = "aeiou";
            return vowels.Contains(c);
        }
        static bool isConsonant(char c)
        {
            const string consonants = "bcdfghjklmnpqrstvwxyz";
            return consonants.Contains(c);
        }
    }
}
