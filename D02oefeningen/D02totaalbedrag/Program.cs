namespace D02totaalbedrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Aantal muntstukken van 1 euro: ");
            int munten1Euro = int.Parse(Console.ReadLine());

            Console.Write("Aantal muntstukken van 2 euro: ");
            int munten2Euro = int.Parse(Console.ReadLine());

            int totaal = munten1Euro + munten2Euro * 2;

            Console.WriteLine($"Het totale bedrag is {totaal} euro.");

        }
    }
}
