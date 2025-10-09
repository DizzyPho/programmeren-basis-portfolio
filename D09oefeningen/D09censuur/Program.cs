using Helper.UserInputHelper;

namespace D09censuur
{
    internal class Program
    {
        static void Main(string[] args)
        {

  

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
        }
    }
}
