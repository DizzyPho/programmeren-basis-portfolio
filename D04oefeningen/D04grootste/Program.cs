using D04geslaagd;

namespace D04grootste
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int getal1 = UserInputHulpKlasse.UserInputGetal("Geef een eerste getal: ");
            int getal2 = UserInputHulpKlasse.UserInputGetal("Geef een tweede getal: ");
            int getal3 = UserInputHulpKlasse.UserInputGetal("Geef een derde getal: ");

            int grootste;
            grootste = Math.Max(getal1, getal2);
            grootste = Math.Max(grootste, getal3);
        }
    }
}
