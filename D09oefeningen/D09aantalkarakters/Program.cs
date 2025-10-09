using System.Diagnostics.Tracing;

namespace D09aantalkarakters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] woorden;

            //woorden = new string[] { "dit", "zijn", "een", "aantal", "woorden" }; // 3,7,10,16,23
            woorden = new string[] { "dit", "zijn", "dan", "weer", "wat", "andere", "woorden" }; // 3,7,10,14,17,23,30

            int[] totalCharacters = new int[woorden.Length];
            int totalCounter = 0;

            for (int index = 0; index < woorden.Length; index++) { 
                int wordLength = woorden[index].Length;
                totalCounter += wordLength;

                totalCharacters[index] = totalCounter;
            }

            Console.WriteLine(string.Join(',', totalCharacters));
        }
    }
}
