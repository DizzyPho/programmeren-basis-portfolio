using Helper.UserInputHelper;

namespace D07leestekens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ");
            bool foundPunct = false;

            int lastIndex = text.Length - 1;
            int index = 0;
            do
            {

                if (Char.IsPunctuation(text[index]))
                {
                    Console.WriteLine("This text has at least one punctuation mark.");
                    foundPunct = true;
                }
                index++;
            } while (!foundPunct && index <= lastIndex);

            if (!foundPunct) {
                Console.WriteLine("This text contains no punctuation marks.");
            }

        }
    }
}
