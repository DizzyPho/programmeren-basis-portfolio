using Helper.UserInputHelper;

namespace D05double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number;
            try
            {
                number = UserInput.DoubleInput("Geef een double getal in: ");
                Console.WriteLine($"Dankje voor het getal ({number})");
            } catch
            {
                Console.WriteLine("Afgebroken wegens geen double.");
            }
        }
    }
}
