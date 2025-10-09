namespace D09censuur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
        }

        static bool HasSwears(string s) {
            string[] swearWords = ["shit", "fuck", "javascript", "astarion", "waegenaar"];
            if (swearWords.Contains(s))
            {
                return true;
            }
            else {
                return false;
            }

        }
    }
}
