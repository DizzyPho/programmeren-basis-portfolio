namespace D04score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef je score op honderd in: ");
            int scorePercent = int.Parse(Console.ReadLine());

            string scoreLetter = scorePercent switch { 
                < 22 => "F",
                < 37 => "E",
                < 52 => "D",
                < 67 => "C",
                < 82 => "B",
                <= 100 => "A",
                _ => "ongeldig",
            };

            if(scoreLetter == "ongeldig")
            {
                Console.WriteLine("Dit is geen geldig percentage!");
            } else
            {
                Console.WriteLine($"Jouw score komt overeen met een {scoreLetter}");
            }

        }
    }
}
