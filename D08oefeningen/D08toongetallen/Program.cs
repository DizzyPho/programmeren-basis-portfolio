namespace D08toongetallen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 1, -1, -3 };
            string output = string.Empty;
            int length = a.Length;

            for (int index = 0; index < length; index++) {
                output += $"{a[index]}";

                if (index != length - 1)  {
                    output += ", ";
                }
            }

            Console.WriteLine(output);
        }
    }
}
