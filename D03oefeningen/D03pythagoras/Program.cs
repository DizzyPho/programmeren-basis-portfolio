namespace D03pythagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef de basis: ");
            int basis = int.Parse(Console.ReadLine());

            Console.Write("Geef de hoogte: ");
            int hoogte = int.Parse(Console.ReadLine());

            double basisKwadraat = Math.Pow(basis, 2);
            double hoogteKwadraat = Math.Pow(hoogte, 2);

            double schuineKwadraat = basisKwadraat + hoogteKwadraat;
            double schuine = Math.Sqrt(schuineKwadraat);

            Console.WriteLine($"De schuine zijde heeft een lengte van {schuine}.");
        }
    }
}
