using Helper.UserInputHelper;

namespace D07beginmethoofdletters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = UserInput.StringInput("Give some text: ");
            string output = "";

            for (int index = 0; index < text.Length; index++)
            {

                if (index < 5)
                {
                    output += Char.ToUpper(text[index]);
                }
                else
                {
                    output += text[index];
                }
            }
            Console.WriteLine(output);
        }
    }
}
