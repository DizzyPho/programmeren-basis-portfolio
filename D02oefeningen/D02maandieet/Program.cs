namespace D02maandieet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je gewicht in kg in: ");
            int gewicht = int.Parse(Console.ReadLine());
            double maanGewicht = gewicht / 6.0;

            Console.WriteLine($"Op de maan weeg jij ongeveer {maanGewicht} kg!");
        }
    }
}
