using UserInput;

namespace D04weer_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool zon = UserInputHulpKlasse.UserInputJaNee("Schijnt de zon?");
            bool regen = UserInputHulpKlasse.UserInputJaNee("Regent het?");

            string weer;
            if (zon)
            {
                if (regen)
                {
                    weer = "Er is een regenboog.";
                }
                else
                {
                    weer = "Het is een mooie dag.";

                }
            }
            else
            {
                if (regen)
                {
                    weer = "Het is slecht weer.";
                }
                else
                {
                    weer = "Het een saaie dag weer.";
                }
            }    

            Console.WriteLine(weer);
        }
    }
}
