using Helper.UserInputHelper;

namespace D07dotdotdot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = UserInput.StringInput("Give me a word: ");

            foreach (char c in word) {
                Console.Write(c + ".");            
            }
        }
    }
}
