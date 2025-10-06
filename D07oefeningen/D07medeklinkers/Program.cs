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
                if (IsVowel(c))
                {
                    vowelCounter++;
                }
                else if (IsConsonant(c))
                {
                    consCounter++;
                } 
            }
            Console.WriteLine($"This text contains {vowelCounter} vowels and {consCounter} consonants.");
        }

        static bool IsVowel(char c)
        {
            const string vowels = "aeiou";
            c = Char.ToLower(c);
            return vowels.Contains(c);
        }
        static bool IsConsonant(char c)
        {
            const string consonants = "bcdfghjklmnpqrstvwxyz";
            c = Char.ToLower(c);
            return consonants.Contains(c);
        }
    }
}
