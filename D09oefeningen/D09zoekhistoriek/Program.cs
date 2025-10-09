using Helper.UserInputHelper;

namespace D09zoekhistoriek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] zoekhistoriek = { "Charlie Sheen", "Hot shots", "Winning", "Electrabel storing", "Geen elektriciteit" };
            while (true) {
                string nextEntry = UserInput.StringInput("Give a next search term: ");

            }
        }

        static string[] ShiftArray(string[] array, string newItem) {

            for (int i = array.Length - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }
                array[0] = newItem;

            return array;
        }
    }
}
