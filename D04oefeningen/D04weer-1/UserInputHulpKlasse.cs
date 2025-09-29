using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    internal class UserInputHulpKlasse
    {
        public static int UserInputGetal(string vraag)
        {
            Console.Write(vraag);
            int input = int.Parse(Console.ReadLine());

            return input;
        }

        public static string UserInput(string vraag)
        {
            Console.Write(vraag);
            string input = Console.ReadLine();

            return input;
        }

        public static bool UserInputJaNee(string vraag)
        {
            Console.Write(vraag + "(ja/nee) ");
            string input = Console.ReadLine();
            bool antwoordIsJa = (input == "ja");

            return antwoordIsJa;
        } 
    }
}
