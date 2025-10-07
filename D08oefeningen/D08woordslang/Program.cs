using Helper.UserInputHelper;

namespace D08woordslang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create array
            //input 5 words via for loop
            //put in array

            //for each loop
            //save last word to temp var
            //break if first of current word != last of last word 
            //else: add word to output string

            string[] words = new string[5];
            for (int i = 0; i < words.Length; i++)
            {
                string word = UserInput.StringInput("Input a word: ");
                words[i] = word;
            }

        }
    }
}
