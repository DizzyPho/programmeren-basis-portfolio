using Helper.UserInputHelper;

namespace D07achterstevoren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ");
            
            int lastIndex = text.Length - 1;
            string output = "";

            for (int i = lastIndex; i >= 0; i--) { 
                output += text[i];
            }

            Console.WriteLine(output);
        }
    }
}
