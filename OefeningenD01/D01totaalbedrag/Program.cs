namespace D01totaalbedrag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int biljettenVan10Euro = 7;
            int biljettenVan5Euro = 6;
            int muntstukkenVan2Euro = 5;
            int muntstukkenVan1Euro = 4;
            int muntstukkenVan50Cent = 3;

            int totaalVolleEuros = biljettenVan10Euro * 10
                             + biljettenVan5Euro * 5
                             + muntstukkenVan2Euro * 2
                             + muntstukkenVan1Euro;

            double totaalBedrag = totaalVolleEuros + 0.50 * muntstukkenVan50Cent;

            Console.WriteLine($"In totaal is dat {totaalBedrag} euro.");
        }
        
    }
}
