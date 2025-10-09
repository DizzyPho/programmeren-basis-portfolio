namespace D09speelkaarten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kleuren = { "harten", "klaver", "schoppen", "ruiten" };
            string[] waarden = { "twee", "drie", "vier", "vijf", "zes", "zeven", "acht", "negen", "tien", "landbouwer", "dame", "koning", "aas" };


            string[] cards = new string[52];

            int counter = 0;
            foreach (string color in kleuren)
            {
                foreach (string value in waarden)
                {
                    cards[counter] = $"{color} {value}";
                    counter++;
                }
            }

            foreach (string card in cards) {
                Console.WriteLine(card);
            }
        }
    }
}
