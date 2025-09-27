namespace D02getalontleden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal in: ");
            string getalTekst = Console.ReadLine();
            int getal = int.Parse(getalTekst);

            int aantalEenheden = getal % 10;
            int aantalTientallen = (getal % 100 - aantalEenheden) / 10;
            int aantalHonderdtallen = (getal - aantalTientallen * 10 - aantalEenheden) / 100;

            Console.WriteLine("Dit getal bestaat uit:\n" +
                             $"{aantalHonderdtallen} x 100\n" +
                             $"{aantalTientallen}  x 10\n" +
                             $"{aantalEenheden}   x 1");


            
            
        }
    }
}
