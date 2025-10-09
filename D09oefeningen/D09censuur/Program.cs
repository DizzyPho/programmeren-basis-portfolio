using Helper.UserInputHelper;

namespace D09censuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string words = UserInput.StringInput("Tell me something: ").ToLower().Trim();
            if (HasSwears(words))
            {
                Console.WriteLine("Niet acceptabel!!!");
                Console.WriteLine(Censor(words));
            }
            else
            {
                Console.WriteLine("Acceptabele text.");
            }


            static bool HasSwears(string s)
            {
                string[] swearWords = ["shit", "fuck", "javascript", "astarion", "waegenaar"];
                string[] words = s.Split(" ");

                foreach (string currentWord in words) {
                    if (swearWords.Contains(currentWord)) {
                        return true;
                    }
                }

                return false;
            }

            static string Censor(string s) {

                string[] swearWords = ["shit", "fuck", "javascript", "astarion", "waegenaar"];
                string[] words = s.Split(" ");

                for (int index = 0; index < words.Length; index++) { 
                    string currentWord = words[index];
                    if (swearWords.Contains(currentWord))
                    {
                        words[index] = new String('*', currentWord.Length);
                    }
                }
                return String.Join(" ", words);
            }
        }
    }
}
