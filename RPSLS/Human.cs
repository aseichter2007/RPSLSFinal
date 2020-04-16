using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player

    {
        public Human()
        {
            SetName();
            //throws = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        public override void SetName()
        {
            Console.WriteLine("Enter name");
            name = Console.ReadLine();
        }
        public override string Throw()
        {
            string output = "";
            bool throwCheck = true;
            while (throwCheck)
            {
                for (int i = 0; i < throws.Count; i++)
                {
                    Console.WriteLine(i + 1 + ". " + throws[i]);
                }
                Console.WriteLine("Choose your destiny in the form of a number");
                output = Console.ReadLine();
                throwCheck = InputCheck(output);
            }

            output = throws[int.Parse(output) - 1];
            return output;
        }
        public bool InputCheck(string output)
        {
            bool throwCheck = true;
            if (output == "1" || output == "2" || output == "3" || output == "4" || output == "5")
            {
                throwCheck = false;
            }
            else
            {
                Console.WriteLine("You dummy, that isnt a single integer between one and 5");
            }
            return throwCheck;
        }

    }
}
