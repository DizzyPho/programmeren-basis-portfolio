using Helper.UserInputHelper;

namespace D07aantalkeere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Give some text: ");
            int eCounter = 0;
            foreach (char c in text) {
                if (isE(c)) { 
                    eCounter++;
                }
            }

            Console.WriteLine($"The character 'e' appears {eCounter} times in this text.");
        }
        static bool isE(char c)
        {
            return Char.ToLower(c) == 'e';
        }

    }
}
