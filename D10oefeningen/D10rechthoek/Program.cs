namespace D10rechthoek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quad(9,3);
        }

        static string Line(int width) {
            return new string('*', width);
        }

        static void Quad(int height, int width)
        {
            string line = Line(width);
            for (int i = 0; i < height; i++)
            {
                Console.WriteLine(line);
            }
        }
    }
}
