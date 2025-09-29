namespace D04bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je gewicht in kg: ");
            double gewicht = double.Parse(Console.ReadLine());

            Console.Write("Geef je lengte in cm: ");
            double lengte = double.Parse(Console.ReadLine());

            double lengteInMeter = lengte / 100;
            double lengteKwadraat = Math.Pow(lengteInMeter, 2);

            double bmi = gewicht / lengteKwadraat;
        }
    }
}
