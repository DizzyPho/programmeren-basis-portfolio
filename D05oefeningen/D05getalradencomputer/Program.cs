using Helper.UserInputHelper;

namespace D05getalradencomputer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int iterationNumber = 0;
            int guess;
            int min = 0;
            int max = 100;
            bool numberGuessed = false;
            do
            {
                guess = rand.Next(min,max);

                string higherLower = UserInput.StringInput($"I guess {guess}. Higher, lower? or correct? ");

                switch (higherLower)
                {
                    case "higher":
                        min = guess;
                        break;
                    case "lower":
                        max = guess;
                        break;
                    case "correct":
                        numberGuessed = true;
                        break;
                    default:
                        Console.WriteLine("Incorrect input.");
                        break;
                }

                iterationNumber++;
            } while (!numberGuessed);

            Console.WriteLine($"I guessed it in {iterationNumber} guesses!");
        }
    }
}
