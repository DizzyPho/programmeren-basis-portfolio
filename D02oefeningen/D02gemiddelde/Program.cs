namespace D02gemiddelde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het eerste getal: ");
            double getal1 = double.Parse(Console.ReadLine());

            Console.Write("Geef het tweede getal: ");
            double getal2 = double.Parse(Console.ReadLine());

            Console.Write("Geef het derde getal: ");
            double getal3 = double.Parse(Console.ReadLine());

            double gemiddelde = (getal1 + getal2 + getal3) / 3;

            Console.WriteLine($"Het gemiddelde van deze getallen is: {gemiddelde}");
        }
    }
}
