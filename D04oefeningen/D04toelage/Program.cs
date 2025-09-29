namespace D04toelage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hoeveel is je jaarinkomen in euro? ");
            int inkomen = int.Parse(Console.ReadLine());

            Console.Write("Hoeveel kinderen zijn er in je gezin?");
            int aantalKinderen = int.Parse(Console.ReadLine());
        }
    }
}
