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
                try
                {
                    int userNumber = UserInput.IntegerInput($"Give number #{currentNumber}: ");
                }
                catch {
                    continue;
                }

                validNumbers++;

            }
        }

        static bool Contains(int value, int[] numbers) {
            return (Array.IndexOf(numbers, value) != -1);
        }


    }
}
