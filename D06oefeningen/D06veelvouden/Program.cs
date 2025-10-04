using Helper.UserInputHelper;

namespace D06veelvouden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lowerBound = UserInput.IntegerInput("Give a lower bound: ");  //exclusive bound
            int upperBound = UserInput.IntegerInput("Give an upper bound: ");

            int sum = 0;

            for (int i = lowerBound; i <= upperBound; i++)
            {
                bool divisibleBy3 = i % 3 == 0;
                bool divisibleBy5 = i % 5 == 0;

                if (divisibleBy3 || divisibleBy5)
                {
                    sum += i;
                }


                
            }
            Console.Write($"Sum is of multiples of five and multiples of three is: {sum}");
        }
    }
}
