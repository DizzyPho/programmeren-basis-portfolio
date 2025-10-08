namespace D09herkansing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] puntenlijst = { 13, 16, 13, 18, 8, 12, 15, 3, 4, 11, 17, 18 };

            bool herkansingNodig = false;
            foreach (int punt in puntenlijst) {
                if (punt < 10) { 
                    herkansingNodig = true;
                    break;
                }
            }
            Console.WriteLine(herkansingNodig);
        }
    }
}
