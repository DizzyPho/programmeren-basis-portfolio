namespace D10vierkantmetparam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Vierkant()
        {
            string line = new string('*', 5);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(line);
            }
        }
    }
}
