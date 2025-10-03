namespace D05twister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] colors = ["geel","groen","rood","blauw"];
            string[] limbs = ["linkerhand", "rechterhand", "linkervoet", "rechtervoet"];

            Random rand = new Random();

            int whichLimb = rand.Next(limbs.Length);
            int whichColor = rand.Next(colors.Length);

            string limb = limbs[whichLimb];
            string color = colors[whichColor];

            Console.WriteLine($"{limb} op {color}!");

            System.Threading.Thread.Sleep(7000);
        }
    }
}
