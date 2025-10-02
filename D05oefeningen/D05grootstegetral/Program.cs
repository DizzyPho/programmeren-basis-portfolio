using Helper.UserInputHelper;

namespace D05grootstegetral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            do
            {
                int addition = UserInput.IntegerInput("Geef een volgend getal in, of -1 om te stoppen en de som te maken: ");

                if (addition == -1)
                {
                    break;
                }
                total += addition;

            } while (true);

            Console.WriteLine($"Total sum is: {total}");

        }
    }
}
}
