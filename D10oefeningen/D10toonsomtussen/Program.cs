namespace D10toonsomtussen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SumBetween(1,4));
        }

        static int SumBetween(int min, int max) {
            int sum = 0;
            for (int i = min; i <= max; i++) { 
                sum += i;
            }
            return sum;
        }
    }
}
