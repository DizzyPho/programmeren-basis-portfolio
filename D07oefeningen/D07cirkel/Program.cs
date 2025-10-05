using Helper.UserInputHelper;

namespace D07cirkel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = Math.PI;
            double radius = UserInput.DoubleInput("Input the circle radius: ");

            double area = PI * Math.Pow(radius, 2);
            double circumference = PI * radius * 2;

            string areaFormatted = $"The area is: {area,0:f3}";
            string circumfFormatted = $"The circumference is: {circumference, 0:f3}";

            Console.WriteLine(areaFormatted);
            Console.WriteLine(circumfFormatted);

        }
    }
}
