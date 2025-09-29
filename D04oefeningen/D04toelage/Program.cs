namespace D04toelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double toelagePercent = 0.03;

            Console.Write("Hoeveel is je jaarinkomen in euro? ");
            int inkomen = int.Parse(Console.ReadLine());

            Console.Write("Hoeveel kinderen zijn er in je gezin?");
            int aantalKinderen = int.Parse(Console.ReadLine());

            if (inkomen <= 20000 && aantalKinderen > 2)
            {
                double toelage = inkomen * toelagePercent;
                Console.WriteLine($"Jouw toelage is {toelage} euro.");
            }

        }
    }
}
