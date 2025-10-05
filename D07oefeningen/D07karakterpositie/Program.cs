using Helper.UserInputHelper;

namespace D07karakterpositie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ");

            for (int i = 0; i < text.Length; i++)
            {
                Console.WriteLine($"{i} = {text[i]}");
            }
        }
    }
}
