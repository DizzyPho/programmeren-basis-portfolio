namespace D04prijsappels
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel kilo appels wil je kopen? ");
            int kiloAppels = int.Parse(Console.ReadLine());

            double prijsPerKilo = kiloAppels switch {
                > 20 => 2,
                > 10 => 2.5,
                _ => 3
            };

            double totalePrijs = prijsPerKilo * kiloAppels;
            Console.WriteLine($"Prijs: {totalePrijs}");
        }
    }
}
