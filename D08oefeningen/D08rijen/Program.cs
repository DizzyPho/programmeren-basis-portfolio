using Helper.UserInputHelper;

namespace D08rijen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array of length 6
            //Ask user for input
            //try to parse, if succeeds, add to 
            //keep track of how many 
            //loop 6 times
            //break if empty thingy

            // calc potential delta/factor based on first 2 items
            // check if delta / factor applies to rest of array
                

        }

        static int[] GetRow() {

            int[] row = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Input the next number, or enter to stop: ");
                string numberText = Console.ReadLine();

                if (numberText == string.Empty)
                {
                    break;
                }

                int number = int.Parse(numberText);
                row[i] = number;
            }

            return row;
        }

        static double potentialFactor(int[] row) { 
            return row[1] / row[0];
        }

        static double potentialDelta(int[] row) {
            return row[1] - row[0];
        }
    }
}
