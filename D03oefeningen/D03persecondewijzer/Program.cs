namespace D03persecondewijzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int secondenPerMinuut = 60;
            const int secondenPerUur = 3600;

            Console.Write("Geef het aantal seconden: ");
            int totaalSeconden = int.Parse(Console.ReadLine());  

            int seconden = totaalSeconden % secondenPerMinuut;
            int rest = totaalSeconden - seconden;

            int minuten = (rest % secondenPerUur) / secondenPerMinuut;
            rest = rest - minuten * secondenPerMinuut;

            int uren = rest / secondenPerUur;

            Console.WriteLine($"Dat zijn {uren} uren, {minuten} minuten en {seconden} seconden.");
        }
    }
}
