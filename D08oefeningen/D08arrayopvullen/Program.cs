namespace D08arrayopvullen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[9];

            // opvullen


            // afdrukken
            for (int index = 0; index < getallen.Length; index++)
            {
                Console.Write(getallen[index] + " ");
            }
        }
    }
}
