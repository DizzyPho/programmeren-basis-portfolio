using Helper.UserInputHelper;

namespace D10rechthoek
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int height = GetValidDimension("Enter the height: ");
            int width = GetValidDimension("Enter the width: ");
            Quad(height,width);
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

        static int GetValidDimension(string message) {

            int dim = -1;
            
            while (dim <= 0)
            {
                try
                {
                    dim = UserInput.IntegerInput(message);
                }
                catch { 
                    continue;
                }
            }
            return dim;
        }
    }
}
