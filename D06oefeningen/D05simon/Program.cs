using Helper.UserInputHelper;

namespace D05simon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberToRemember = "";
            string userGuess;
            do
            {
                Random random = new Random();
                int randomNumber = random.Next(1, 5);

                numberToRemember += randomNumber;

                Console.WriteLine($"You have 3 seconds to remember this number: \n{numberToRemember}");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();

                userGuess = UserInput.StringInput("Type the number here: ");
                Console.Clear();
            } while (userGuess == numberToRemember);

            Console.WriteLine($"You lost! The number was: {numberToRemember}");
        }
    }
}
