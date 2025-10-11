namespace D11charcount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine(GetCharCount("Hello World",'H')); 
        }

        static int GetCharCount(string str, char c)
        {
            int charCount = 0;
            int foundAtIndexPrevious = -1;
            while (true)
            {

                int foundAtIndex = str.IndexOf(c, foundAtIndexPrevious + 1);
                if (foundAtIndex == -1)
                {
                    break;
                }
                else
                {
                    charCount += 1;
                }
                foundAtIndexPrevious = foundAtIndex;
            }
            return charCount;
        }


    }
}
