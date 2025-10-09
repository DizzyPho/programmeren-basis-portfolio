using Helper.UserInputHelper;

namespace D09vijfkleinste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            while (numbers.Count < 10) {

                int newNumber = UserInput.IntegerInput("Enter a number");
                numbers.Add(newNumber);                    
            }

 
        }
    }
}
