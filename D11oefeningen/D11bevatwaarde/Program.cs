using Helper.UserInputHelper;

namespace D11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validNumbersCounter = 0;
            int[] uniqueNumbers = new int[5];

            while (validNumbersCounter < 5) {

                int userNumber;
                try
                {
                    userNumber = UserInput.IntegerInput($"Give number #{validNumbersCounter + 1}: ");
                }
                catch {
                    continue;
                }

                if (Contains(userNumber, uniqueNumbers))
                {
                    continue;
                }

                uniqueNumbers[validNumbersCounter] = userNumber;
                validNumbersCounter++;

            }
        }

        static bool Contains(int value, int[] numbers) {
            return (Array.IndexOf(numbers, value) != -1);
        }


    }
}
