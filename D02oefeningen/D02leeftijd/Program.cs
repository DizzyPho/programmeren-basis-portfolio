namespace D02leeftijd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deze oefening voldoet ook aan de vereisten van oefening D03leeftijdinterpolatie
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();

            Console.Write("Geef je leeftijd: ");
            string leeftijd = Console.ReadLine();

            Console.WriteLine($"Hallo {naam}, jij bent dus {leeftijd} jaar oud?");
        }
    }
}
