using Helper.UserInputHelper;

namespace D09zoekhistoriek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                string nextEntry = UserInput.StringInput("Give a next search term: ");
            }
        }
    }
}
