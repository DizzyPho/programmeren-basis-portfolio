namespace D03cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            const double PI = Math.PI;

            Console.Write("Geef de straal van de cirkel: ");
            double straal = double.Parse(Console.ReadLine());

            double oppervlakte = Math.Pow(straal, 2) * PI;
            double omtrek = 2 * straal * PI;

            Console.WriteLine($"De oppervlakte is {oppervlakte} en de omtrek is {omtrek}");
            

        }
    }
}
