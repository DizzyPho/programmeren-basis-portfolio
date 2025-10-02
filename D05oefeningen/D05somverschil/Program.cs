using Helper.UserInputHelper;
using System.Reflection.Metadata.Ecma335;

namespace D05somverschil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Begin!");
            int initialNumber = UserInput.IntegerInput("");
            int totaal = initialNumber;
            do
            {
                string operatorText = UserInput.StringInput("");
                if (operatorText == "=") { break; }

                int newNumber = UserInput.IntegerInput("");

                totaal = operatorText switch
                {
                    "-" => totaal - newNumber,
                    "+" => totaal + newNumber,
                    _ => totaal
                };

            } while (true);

            Console.WriteLine(totaal);
        }
    }
}
