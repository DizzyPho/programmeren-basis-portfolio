namespace D10dagen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main()
            {
                do
                {
                    Console.Write("Jaar?: ");
                    int jaar = int.Parse(Console.ReadLine());
                    Console.WriteLine($"In februari van {jaar} zijn er {...} dagen.");
                    Console.WriteLine();
                } while (true);
            }



static bool IsSchrikkeljaar(int jaartal)
            {
                return (jaartal % 400 == 0 || jaartal % 4 == 0 && jaartal % 100 != 0);
            }
        }
    }
}
