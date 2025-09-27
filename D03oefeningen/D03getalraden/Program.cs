namespace D03getalraden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomGetal = random.Next(0, 11);
            Console.WriteLine("De computer denkt aan een getal van 0 tot 10.");
            Console.Write("Welk getal denkt u dat het is? ");

            int userGetal = int.Parse(Console.ReadLine());

            if (userGetal == randomGetal)
            {
                Console.WriteLine("Proficiat, u heeft het getal geraden!");
            }
            else
            {
                Console.WriteLine($"Helaas, het getal was {randomGetal}");
            }
        }
    }
}
