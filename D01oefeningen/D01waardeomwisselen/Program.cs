namespace D01waardeomwisselen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 13;

            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
