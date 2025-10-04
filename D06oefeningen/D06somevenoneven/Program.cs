using Helper.UserInputHelper;

namespace D06somevenoneven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userNumber;

            int evens = 0;
            int evenSum = 0;

            int odds = 0;
            int oddSum = 0;


            do
            {
                try
                {
                    userNumber = UserInput.IntegerInput("Give a number (negative to quit): ");
                }
                catch
                {
                    Console.WriteLine("Geef een getal in!");
                    userNumber = 0;
                    continue;
                }

                bool isEven = userNumber % 2 == 0;

                if (isEven)
                {
                    evens++;
                    evenSum += userNumber;
                }
                //beter dit, of while true loop en uit breaken indien <0
                else if (userNumber > 0)
                {
                    odds++;
                    oddSum += userNumber;
                }

            } while (userNumber >= 0);

            Console.WriteLine($"There were {evens} even numbers. Their sum was {evenSum}");
            Console.WriteLine($"There were {odds} odd numbers. Their sum was {oddSum}");
        }
    }
}
