using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04geslaagd
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
    }
}
