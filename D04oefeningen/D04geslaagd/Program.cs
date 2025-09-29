namespace D04geslaagd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int score1 = UserInputHulpKlasse.UserInputGetal("Wat is je eerste score op 10? ");
            int score2 = UserInputHulpKlasse.UserInputGetal("Wat is je tweede score op 10? ");
            int score3 = UserInputHulpKlasse.UserInputGetal("Wat is je derde score op 10? ");

            int totaleScore = score1 + score2 + score3;

            string resultaat;
            if (score1 > 4 && score2 > 4 && score3 > 4)
            {
                resultaat = "Geslaagd!";
            } else if (totaleScore >= 18)
            {
                resultaat = "Geslaagd!";
            } else
            {
                resultaat = "Gefaald.";
            }
        }
       }
}
