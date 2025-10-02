using Helper.UserInputHelper;

namespace D05driehoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int triangleBase = UserInput.IntegerInput("Input base length: ");
            int height = UserInput.IntegerInput("Input height: ");

            string line = "";

            for (int i = 0; i < triangleBase; i++)
            {
                line += "*";
            }

            for (int i = 0; i < height; i++)
            {
                line = line.Substring(0, triangleBase - i);
                Console.WriteLine(line);
                
            }
        }
    }
}
