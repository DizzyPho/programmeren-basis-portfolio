using Helper.UserInputHelper;

namespace D09dagnrnaarmaand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] aantalDagen = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            string[] maandNamen = { "Januari", "Februari", "Maart", "April", "Mei", "Juni", "Juli", "Augustus", "September", "Oktober", "November", "December" };

            int dayNumber = UserInput.IntegerInput("Geef een dagnummer: ");

            int totalDays = 0;
            for (int index = 0; index < aantalDagen.Length; index++) {

                totalDays += aantalDagen[index];

                if (dayNumber <= totalDays) {
                    string month = maandNamen[index];
                    Console.WriteLine($"De maand is {month}.");
                    break;
                }

            }
        }
    }
}
