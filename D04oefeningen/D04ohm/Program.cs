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
                    break;
                case "weerstand":
                    break;
                case "stroomsterkte":
                    break;

                default:
                    Console.WriteLine("Deze optie is niet herkend. Probeer opnieuw!");
                    break;
            }
        }
    }
}
