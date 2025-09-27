namespace D02gelijk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het eerste getal in: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef het tweede getal in: ");
            int getal2 = int.Parse(Console.ReadLine());

            if (getal1 == getal2)
            {
                Console.WriteLine("Ze zijn gelijk.");
            }
            else 
            {
                Console.WriteLine("Ze zijn niet gelijk.");
            }

        }
    }
}
