namespace D11palindroom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("parterretrap"));

        }

        static string ReverseText(string text)
        {

            string reversed = string.Empty;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversed += text[i];
            }
            return reversed;
        }

        static bool IsPalindrome(string text)
        {
            return text == ReverseText(text);
        }
    }
}
