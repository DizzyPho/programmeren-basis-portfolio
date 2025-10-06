using Helper.UserInputHelper;

namespace D07tussenaccolades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ");
            int startIndex = findOpenAccolade(text) + 1;
            int endIndex = findCloseAccolade(text);

            string output = "";

            if (startIndex == 0 || endIndex == -1)
            {
                output = "Found nothing.";
            } 
            else
            {
                for (int index = startIndex; index < endIndex; index++)
                {
                    output += text[index];
                }
            }
            Console.WriteLine(output);

            static int findOpenAccolade(string text)
            {
                return text.IndexOf('{');
            }

            static int findCloseAccolade(string text)
            {
                return text.IndexOf('}');
            }
        }
    }
}
