namespace D04ohm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kies wat je wil berekenen: spanning, weerstand of stroomsterkte? ");
            string optie = Console.ReadLine().ToLower();

            double I;
            double U;
            double R;

            switch (optie)
            {
                case "spanning":
                    Console.Write("Geef de stroomsterkte: ");
                    I = double.Parse(Console.ReadLine());
                    Console.Write("Geef de weerstand: ");
                    R = double.Parse(Console.ReadLine());

                    U = R * I;
                    Console.WriteLine($"De spanning is {U}");

                    break;
                case "weerstand":
                    Console.Write("Geef de stroomsterkte: ");
                    I = double.Parse(Console.ReadLine());
                    Console.Write("Geef de spanning: ");
                    U = double.Parse(Console.ReadLine());

                    R = U / I;
                    Console.WriteLine($"De weerstand is {R}");

                    break;
                case "stroomsterkte":
                    Console.Write("Geef de spanning: ");
                    U = int.Parse(Console.ReadLine());
                    Console.Write("Geef de weerstand: ");
                    R = int.Parse(Console.ReadLine());

                    I = U / R;
                    Console.WriteLine($"De stroomsterkte is {I}");

                    break;
                default:
                    Console.WriteLine("Deze optie is niet herkend. Probeer opnieuw!");
                    break;
            }
        }
    }
}
