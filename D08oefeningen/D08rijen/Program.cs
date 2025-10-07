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
            double[] row = GetRow();

            double potentialDelta = PotentialDelta(row);
            if (IsArethmeticRow(potentialDelta, row)) {
                Console.WriteLine($"This is an arethmetic row with delta {potentialDelta}.");
                return;
            } 

            double potentialFactor = PotentialFactor(row);
            if (IsGeometricRow(potentialFactor, row)) {
                Console.WriteLine($"This is a geometric row with factor {potentialFactor}.");
            }

            Console.WriteLine("This is a normal row.");

        }

        static double[] GetRow() {

            double[] row = new double[6];
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

        static double PotentialFactor(double[] row) { 
            return row[1] / row[0];
        }

        static double PotentialDelta(double[] row) {
            return row[1] - row[0];
        }

        static bool IsArethmeticRow(double delta, double[] row) {

            for (int i = 0; i < row.Length - 1; i++) {
                double current = row[i];
                double next = row[i + 1];
                if (next != current + delta && next != 0) { 
                    return false;
                }
            }

            return true;
        }

        static bool IsGeometricRow(double factor, double[] row) {

            for (int i = 0; i < row.Length - 1; i++)
            {
                double current = row[i];
                double next = row[i + 1];
                if (next != current * factor && next != 0)
                {
                    return false;
                }
            }

            return true;
        }

    }
}
