using System.Reflection.Metadata.Ecma335;

namespace D09durstenfeld
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        static string[] SetKaarten()
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

            return cards;
        }

        static string[] SwapTwo(string[] array, int index1, int index2) {
            string temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;

            return array;
        }

        static string[] DurstenShuffle(string[] array) {

            int len = array.Length;
            Random rand = new Random();

            for (int index = len - 1; index >= 0; index--) {
                int randomNum = rand.Next(0, index + 1);
                array = SwapTwo(array, 0, randomNum);
            }

            return array;
        }
    }

}
