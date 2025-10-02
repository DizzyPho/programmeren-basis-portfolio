namespace D05tafelsvan7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = 1;
            do {
                int multiplied = currentNumber * 7;

                Console.WriteLine($"{currentNumber} * 7 = {multiplied}");

                currentNumber++;
            } while (currentNumber <= 10);
        }
    }
}
