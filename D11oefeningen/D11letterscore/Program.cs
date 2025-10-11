namespace D11letterscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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
