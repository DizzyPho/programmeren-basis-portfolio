namespace D07veelvoudvan9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 15; i+=2)
            {
                int multiple = i * 9;
                string formatted = $"{i,2:d0} x 9 = {multiple,3:d0}";
                Console.WriteLine(formatted);
            }
        }
    }
}
