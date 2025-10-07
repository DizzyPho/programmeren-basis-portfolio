namespace D08posititiezoeken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3, 3, 9, -4 };

            const int numberToFind = 8;

            string indexes = string.Empty;
            bool noInstancesLeft = false;

            int previousInstance = -1;
            while (!noInstancesLeft) { 
                
                
                int foundAtIndex = Array.IndexOf(a, numberToFind, previousInstance + 1);

                if (foundAtIndex == -1)
                {
                    noInstancesLeft = true;
                }
                else {
                    indexes += foundAtIndex + " ";
                }
                previousInstance = foundAtIndex;
            }

            if (indexes == string.Empty) {
                Console.WriteLine("No instances found.");
            } else
            {

                Console.WriteLine($"Found {numberToFind} at index(es): {indexes}");
            }
        }
    }
}
