namespace D10vierkant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vierkant();
        }

        static void Vierkant() {
            string line = new string('*', 5);
            for (int i = 0; i < 5; i++) {
                Console.WriteLine(line);
            }
        }
    }
}
