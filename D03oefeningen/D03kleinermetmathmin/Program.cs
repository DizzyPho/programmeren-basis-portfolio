namespace D03kleinermetmathmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het eerste getal: ");
            int getal1 = int.Parse(Console.ReadLine());

            Console.Write("Geef het tweede getal: ");
            int getal2 = int.Parse(Console.ReadLine());

            int kleinsteGetal = Math.Min(getal1, getal2);

            Console.WriteLine($"{kleinsteGetal} is kleiner.");
        }
    }
}
