using Helper.UserInputHelper;

namespace D05rechthoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = UserInput.IntegerInput("Input width: ");
            int height = UserInput.IntegerInput("Input height: ");

            string line = "";

            for (int i = 0; i < width; i++)
            {
                line += " * ";
            }

            for (int i = 0;i < height; i++)
            {
                Console.WriteLine(line);
            }
        }
    }
}
