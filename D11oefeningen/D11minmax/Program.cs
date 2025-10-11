namespace D11minmax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nrs = { -4, 7, 9, 34, 2, 56, 34, 78 };
            Console.WriteLine(GetMin(nrs));
            Console.WriteLine(GetMax(nrs));
        }

        static int GetMin(int[] numbers) {

            int min = int.MaxValue;

            foreach (int currentNumber in numbers) { 
                    
                min = Math.Min(min, currentNumber); 

            }

            return min; 

        }

        static int GetMax(int[] numbers)
        {

            int max = int.MinValue;

            foreach (int currentNumber in numbers)
            {

                max = Math.Max(max, currentNumber);

            }

            return max;

        }
    }
}
