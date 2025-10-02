using Helper.UserInputHelper;

namespace D05getalraden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 101);
            do
            {
                int guess = UserInput.IntegerInput("Guess a number: ");
                string result;

                if (guess > randomNum)
                {
                    result = "lager!";
                }
                else if (guess < randomNum)
                {
                    result = "hoger!";
                }
                else
                {
                    result = "Disco!!!";
                    Console.WriteLine(result);
                    break;
                }
                Console.WriteLine(result);
            } while (true);
        }
    }
}
