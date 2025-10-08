using Helper.UserInputHelper;

namespace D09toonscore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vakken = { "frans", "engels", "wiskunde", "duits", "l.o." };
            int[] scores = { 34, 55, 20, 10, 80 };

            string whichSubj = UserInput.StringInput("Van welk vak wil je je punten zien? ").ToLower();

            int subject = Array.IndexOf(vakken, whichSubj);

            if (subject == -1)
            {
                Console.WriteLine("Vak niet gevonden.");
            }
            else {
                int score = scores[subject];
                Console.WriteLine($"Je score voor {whichSubj} is {score}/100.");
            }
        }
    }
}
