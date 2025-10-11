using Helper.UserInputHelper;

namespace D11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validNumbers = 0;
            int[] uniqueNumbers = new int[5];

            while (validNumbers < 5) {

                int currentNumber = validNumbers + 1;
                int userNumber = UserInput.IntegerInput($"Give number #{currentNumber}: ");

                validNumbers++;

            }
        }

        static bool Contains(int value, int[] numbers) {
            return (Array.IndexOf(numbers, value) != -1);
        }


    }
}
