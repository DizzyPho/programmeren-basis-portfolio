using Helper.UserInputHelper;

namespace D09getalfrequentie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] zeroToTen = new int[11];

            while (true)
            {
                string input = UserInput.StringInput("Geef een getal in [0,10]: ").ToLower().Trim();

                if (input == "stop") {
                    break;
                }

                int number = int.Parse(input);

                if (number > 10 || number < 0) {
                    Console.WriteLine("Not in [0,10].");
                    continue;
                }

                zeroToTen[number] += 1;
                
            }
        }
    }
}
