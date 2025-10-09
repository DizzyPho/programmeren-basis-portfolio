namespace D10dagen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.Write("Maand?: ");
                int maand = int.Parse(Console.ReadLine());
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                string[] maanden = {"januari", "februari", "maart", "april", "mei", "juni", "juli",
                        "augustus", "september", "oktober", "november", "december"};

                int aantalDagen = DagenMaand(maand - 1, jaar);

                Console.WriteLine($"In {maanden[maand - 1]} van {jaar} zijn er {aantalDagen} dagen.");
                Console.WriteLine();

            } while (true);


            static int DagenFebruari(int jaar)
            {
                int dagen = IsSchrikkeljaar(jaar) ? 29 : 28;
                return dagen;
            }

            static bool IsSchrikkeljaar(int jaartal)
            {
                return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
            }

            static int DagenMaand(int maand, int jaar)
            {
                if (maand == 1)
                {
                    return DagenFebruari(jaar);
                }

                int[] months31Days = [0, 2, 4, 6, 7, 9, 11];

                if (months31Days.Contains(maand))
                {
                    return 31;
                }
                else { return 30; }
            }
        }
    }
}
