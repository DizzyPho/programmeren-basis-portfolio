using Helper.UserInputHelper;

namespace D05reeks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = UserInput.IntegerInput("Give a first number: ");
            int num2 = UserInput.IntegerInput("Give a second number: ");

            int largest = Math.Max(num1, num2);
            int smallest = Math.Min(num1, num2);

            int currentNum = smallest;

            do
            {
                Console.WriteLine(currentNum);
                currentNum++;
            } while (currentNum <= largest);
        }
    }
}
