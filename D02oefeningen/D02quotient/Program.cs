namespace D02quotient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een deeltal: ");
            double deeltal = int.Parse(Console.ReadLine());
            
            Console.Write("Geef een deler: ");
            double deler = int.Parse(Console.ReadLine());

            double quotient = deeltal / deler;

            if (deler != 0)
            {
                Console.WriteLine($"Quotient is {quotient}");
            } else
            {
                Console.WriteLine("Error. Deler mag niet 0 zijn");
            }

        }
    }
}
