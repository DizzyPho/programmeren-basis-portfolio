namespace D05twintigtottien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int currentNumber = 20;
            do {
                Console.WriteLine(currentNumber);
                currentNumber -= 2;

            } while (currentNumber >= 10);
        }
    }
}
