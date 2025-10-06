namespace D07medeklinkers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
