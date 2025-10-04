using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.UserInputHelper
{
        internal class UserInput
        {
            public static string StringInput(string query)
            {
                Console.Write(query);
                string input = Console.ReadLine();

                return input;
            }

        public static int IntegerInput(string query)
        {
            int input = int.Parse(StringInput(query));

            return input;
        }

        public static double DoubleInput(string query)
        {
            double input = double.Parse(StringInput(query));

            return input;
        }
        public static bool AnswerIsYes(string query)
        {

            string input = StringInput(query + "(yes/ja or no/nee) ");
            input = input.ToLower().Trim();

            bool answerIsYes = (input == "ja" || input == "yes");

            return answerIsYes;
        }

    }
    }