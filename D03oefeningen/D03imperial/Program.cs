namespace D03imperial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double cmsInFoot = 30.48;
            const double cmsInInch = 2.54;

            Console.Write("Geef het aantal feet : ");
            string aantalFeetAlsTekst = Console.ReadLine();
            double aantalFeet = double.Parse(aantalFeetAlsTekst);

            Console.Write("Geef het aantal inches : ");
            string aantalInchesAlsTekst = Console.ReadLine();
            double aantalInches = double.Parse(aantalInchesAlsTekst);

            double aantalFeetInCm = aantalFeet * cmsInFoot;
            double aantalInchesInCm = aantalInches * cmsInInch;

            double totaalInCm = aantalFeetInCm + aantalInchesInCm;

            Console.WriteLine($"Dat is {totaalInCm}cm."); ;
        }
    }
}
