using Helper.UserInputHelper;

namespace D06somtussengrenzen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = UserInput.IntegerInput("Give a lower bound: ") + 1;  //exclusive bound
            int upperBound = UserInput.IntegerInput("Give an upper bound: ");

            int sum = 0;

            for (int i = lowerBound; i < upperBound; i++)
            {
                string sumString = i == upperBound - 1 ? $"{i} " : $"{i} + ";

                Console.Write(sumString);
                sum += i;
            }
            
            Console.Write($"= {sum}");
        }
    }
}
