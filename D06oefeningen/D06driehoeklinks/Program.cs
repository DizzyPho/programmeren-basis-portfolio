using Helper.UserInputHelper;

namespace D06driehoeklinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = UserInput.IntegerInput("Give triangle height: ");

            string triangleRow = "";

            for (int i = 0; i < height; i++)
            {
                triangleRow += " * ";
                Console.WriteLine(triangleRow);
            }
        }
    }
}
