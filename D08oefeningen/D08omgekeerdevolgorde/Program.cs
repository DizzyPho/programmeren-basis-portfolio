
using Helper.UserInputHelper;
using System.ComponentModel.DataAnnotations;

namespace D08omgekeerdevolgorde
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ask amount and create array w that length
            //for loop + userinput to fill array
            //for loop starting from back of array. 

            int amountOfNames = UserInput.IntegerInput("How many names would you like to input?");
            string[] names = new string[amountOfNames];

            for (int index = 0; index < amountOfNames; index++)
            {
                string name = UserInput.StringInput("Input a name: ");
                names[index] = name;
            }

            for (int index = amountOfNames - 1; index >= 0; index--)
            {
                Console.WriteLine(names[index]);
            }

        }
    }
}
