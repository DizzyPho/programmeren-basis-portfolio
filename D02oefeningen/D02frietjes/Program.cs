﻿namespace D02frietjes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Deze oefening voldoet ook aan de vereisten van oefening D03frietjesinterpolatie
            Console.WriteLine("Geef een naam:");
            string naam1 = Console.ReadLine();

            Console.WriteLine("Geef nog een naam:");
            string naam2 = Console.ReadLine();

            Console.WriteLine("Noem een gerecht: ");
            string gerecht = Console.ReadLine();

            Console.WriteLine($"{naam1} en {naam2} eten graag {gerecht}.");
        }
    }
}
