using Helper.UserInputHelper;

namespace D07hoofdletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Input some text: ");

            char firstLetter = text[0];

            if (Char.IsUpper(firstLetter))
            {
                Console.WriteLine("This text starts with a capital letter.");

            }
            else {
                Console.WriteLine("This text doesn't start with a capital letter");
            }
        }
    }
}
