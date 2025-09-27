namespace D02volwassen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoe oud ben je? ");
            int leeftijd = int.Parse(Console.ReadLine());

            if (leeftijd >= 18)
            {
                Console.WriteLine("Jij bent volwassen!");
            }
            else
            {
                Console.WriteLine("Jij bent nog niet volwassen.");
            }
        }
    }
}
