namespace D01bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengteInCm = 182;
            int gewichtInKg = 72;

            //note to self: Divide by 100.00 to get result as type double, don't divide by 100
            double lengteInMeters = lengteInCm / 100.00;

            double bmi = gewichtInKg / Math.Pow(lengteInMeters, 2);

            Console.WriteLine(bmi);
        }
    }
}
