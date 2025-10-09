namespace D10dagen
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.Write("Jaar?: ");
                int jaar = int.Parse(Console.ReadLine());
                int aantalDagen = DagenFebruari(jaar);
                Console.WriteLine($"In februari van {jaar} zijn er {aantalDagen} dagen.");
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
        }
    }
}
