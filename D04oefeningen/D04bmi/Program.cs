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

            string gewichtCategorie = bmi switch
            {
                < 18.5 => "ondergewicht",
                < 25 => "normaal gewicht",
                < 30 => "overgewicht",
                < 40 => "zwaarlijvigheid",
                _ => "ernstige zwaarlijvigheid"
            };
            
            
        }
    }
}
