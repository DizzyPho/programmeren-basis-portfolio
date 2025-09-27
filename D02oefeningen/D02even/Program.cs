namespace D02even
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int getal = int.Parse(Console.ReadLine());

            if (getal % 2 == 0)
            {
                Console.WriteLine("Getal is even");
            } else
            {
                Console.WriteLine("Getal is oneven");
            }
        }
    }
}
