using Helper.UserInputHelper;

namespace D09namenalfabetisch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            string name;

            do {
                name = UserInput.StringInput("Enter a name or press enter to stop: ");
                names.Add(name);
            } while (name != string.Empty);

            names.Sort();

            foreach (string currentName in names) {
                Console.WriteLine(currentName);
            }
        }
    }
}
