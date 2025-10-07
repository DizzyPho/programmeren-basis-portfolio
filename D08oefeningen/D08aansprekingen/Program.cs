namespace D08aansprekingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] aansprekingen = { "Jan", "Piet", "Pol" };

            for (int index = 0; index < aansprekingen.Length; index++)
            {
                string naam = aansprekingen[index];
                aansprekingen[index] = $"Dag {naam}";
            }

            foreach (string aanspreking in aansprekingen)
            {
                Console.WriteLine(aanspreking);
            }
        }
    }
}
