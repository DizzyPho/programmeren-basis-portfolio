using Helper.UserInputHelper;

namespace D05grootstegetral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int largest = 0;

            do
            {
                int nextNum = UserInput.IntegerInput("Geef een volgend getal in, of -1 om te stoppen en" +
                    "het grootste te vinden: ");

                if (nextNum == -1)
                {
                    break;
                }

                largest = Math.Max(largest, nextNum);


            } while (true);

            Console.WriteLine($"Grootste getal is: {largest}");

        }
    }
}

