using Helper.UserInputHelper;

namespace D06somtussengrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = UserInput.IntegerInput("Give a lower bound: ");
            int upperBound = UserInput.IntegerInput("Give an upper bound: ");
        }
    }
}
