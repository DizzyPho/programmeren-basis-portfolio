using Helper.UserInputHelper;

namespace D09getalfrequentie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = UserInput.StringInput("Geef een getal in [0,10]: ").ToLower().Trim();

                if (input == "stop") {
                    break;
                }

                int number = int.Parse(input);
            }
        }
    }
}
