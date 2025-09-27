namespace D02som
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deze oefening voldoet ook aan de vereisten van oefening D03sominterpolatie
            Console.Write("Geef het eerste getal: ");
            int eersteGetal = int.Parse(Console.ReadLine());

            Console.Write("Geef het tweede getal: ");
            int tweedeGetal = int.Parse(Console.ReadLine());

            int som = eersteGetal + tweedeGetal;

            Console.WriteLine($"{eersteGetal} plus {tweedeGetal} is {som}");
        }
    }
}
