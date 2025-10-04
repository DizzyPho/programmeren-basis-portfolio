using Helper.UserInputHelper;

namespace D06somevenoneven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            do
            {
                try
                {
                    userNumber = UserInput.IntegerInput("Give a number (negative to quit): ");
                }
                catch
                {
                    Console.WriteLine("Geef een getal in!");
                    userNumber = -1;
                    continue;                 
                }
                Console.WriteLine("test");
            } while (userNumber >= 0);
        }
    }
}
