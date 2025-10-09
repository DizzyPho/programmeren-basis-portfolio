namespace D10vierkantmetparam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void Vierkant(int lengte)
        {
            string line = new string('*', lengte);
            for (int i = 0; i < lengte; i++)
            {
                Console.WriteLine(line);
            }
        }
    }
}
