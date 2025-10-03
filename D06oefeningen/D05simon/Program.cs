namespace D05simon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberToRemember = "";

            Random random = new Random();
            int randomNumber = random.Next(1, 5);

            numberToRemember += randomNumber;

        }
    }
}
