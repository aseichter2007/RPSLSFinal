using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Human : Player

    {
        public Human()
        {
            this.name = GetName();
            //throws = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        public override string GetName()
        {
            Console.WriteLine("Enter name");
            string output = Console.ReadLine();
            return output;
        }
        public override string Throw()
        {
            return base.Throw();
        }

    }
}
