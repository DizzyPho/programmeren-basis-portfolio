using Helper.UserInputHelper;

namespace D05fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = UserInput.IntegerInput("How many months? ");

            int iterationNumber = 1;

            //definition of fibonacci row
            int previousFiboNumber = 0;
            int currentFiboNumber = 1;

            do
            {
                Console.WriteLine(currentFiboNumber);

                int temp = currentFiboNumber;
                currentFiboNumber += previousFiboNumber;
                previousFiboNumber = temp;



                iterationNumber++;
            } while (iterationNumber <= months);
        }
    }
}
