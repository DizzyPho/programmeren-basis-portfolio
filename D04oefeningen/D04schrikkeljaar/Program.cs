using D04geslaagd;

namespace D04schrikkeljaar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jaartal = UserInputHulpKlasse.UserInputGetal("Geef een jaartal in: ");

            bool deelbaarDoorVier = jaartal % 4 == 0;
            bool deelbaarDoor100 = jaartal % 100 == 0;
            bool deelbaarDoor400 = jaartal % 400 == 0;

            if ((deelbaarDoorVier && !deelbaarDoor100) || deelbaarDoor400)
            {
                Console.WriteLine("Dit is een schrikkeljaar!");
            }
            else
            {
                Console.WriteLine("Dit is geen schrikkeljaar.");
            }

        }
    }
}
