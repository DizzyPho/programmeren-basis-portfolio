using Helper.UserInputHelper;

namespace D06driehoekrechts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = UserInput.IntegerInput("Give triangle height: ");

            string row = new String(' ', height);

            for (int i = 0; i < height; i++)
            {
                int secondLastEmptySpace = height - i - 1;
                row = row.Remove(secondLastEmptySpace, 1).Insert(secondLastEmptySpace, "*");
                Console.WriteLine(row);
            }
        }
    }
}

