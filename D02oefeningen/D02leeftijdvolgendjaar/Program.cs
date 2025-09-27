namespace D02leeftijdvolgendjaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je naam: ");
            string naam = Console.ReadLine();

            Console.Write("Geef je leeftijd: ");
            int leeftijd = int.Parse(Console.ReadLine());

            int leeftijdVolgendJaar = leeftijd + 1;


            Console.WriteLine($"Oei Oei {naam}, jij bent volgend jaar al {leeftijdVolgendJaar} jaar oud?");
           
        }
    }
}
