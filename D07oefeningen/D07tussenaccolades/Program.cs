namespace D07tussenaccolades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            static int findOpenAccolade(string text) {
                return text.IndexOf('{');            
            }

            static int findCloseAccolade(string text)
            {
                return text.IndexOf('}');
            }
        }
    }
}
