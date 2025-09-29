using UserInput;

namespace D04weer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool zon = UserInputHulpKlasse.UserInputJaNee("Schijnt de zon?");
            bool regen = UserInputHulpKlasse.UserInputJaNee("Regent het?");

            string weer;
            if (zon && regen)
            {
                weer = "Er is een regenboog.";
            }
            else if (zon && !regen)
            {
                weer = "Het is een mooie dag.";
            }
            else if (!zon && regen) 
            {
                weer = "Het is slecht weer.";       
            }
            else
            {
                weer = "Het is een saaie dag.";
            }

            Console.WriteLine(weer);
        }
    }
}
