namespace D10overlappend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsOverlapping(1, 3, 4, 13));
        }

        static bool IsOverlapping(int min1, int max1, int min2, int max2)
        {
            return (max1 >= min2) || (max2 >= min1);
        }
    }
}
