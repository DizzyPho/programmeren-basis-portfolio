using Helper.UserInputHelper;

namespace D09boerderij
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] boerderijDieren = { "kip", "koe", "paard", "geit", "schaap" };

            string whichAnimal = UserInput.StringInput("Welke dier wil je opzoeken? ").ToLower();
            int foundAnimal = Array.IndexOf(boerderijDieren, whichAnimal);

            if (foundAnimal == -1)
            {
                Console.WriteLine("Dit is geen boerderijdier!");
            }
            else {
                Console.WriteLine($"{whichAnimal} is een boerderijdier.");
            }
        }
    }
}
