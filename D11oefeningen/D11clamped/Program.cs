namespace D11clamped
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Clamp(1, 11, 10));
        }

        static int Clamp(int min, int number, int max) {

            int clampedNum;

            if (number < min)
            {
                clampedNum = min;
            }
            else if (number > max)
            {
                clampedNum = max;
            }
            else
            {
                clampedNum = number;
            }   
            return clampedNum;
        }
    }
}
