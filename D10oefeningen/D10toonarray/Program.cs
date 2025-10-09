namespace D10toonarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 4, 7, 9, 34, 2, 56, 34, 78 };
            PrintArray(nums);
        }


        static void PrintArray(int[] array) {
            string arrayText = String.Join(", ", array);
            Console.WriteLine(arrayText); 
        }


    }
}
