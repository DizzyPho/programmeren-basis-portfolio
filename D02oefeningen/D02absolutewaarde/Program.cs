namespace D02absolutewaarde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            double getal = double.Parse(Console.ReadLine());

            double abs;
            if (getal >= 0)
            {
                abs = getal;
            } else
            {
                abs = getal * -1;
            }
            Console.WriteLine($"Absolute waarde is {abs}");
        }
    }
}
