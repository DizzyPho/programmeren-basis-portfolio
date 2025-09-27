namespace D02temperatuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de temperatuur in graden fahrenheit: ");
            double fahrenheit = double.Parse(Console.ReadLine());

            double celsius = (5 / 9.0) * (fahrenheit - 32);

            Console.WriteLine($"In celsius is dat {celsius} graden.");  
        }
    }
}
