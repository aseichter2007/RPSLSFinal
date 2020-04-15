using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Paper : Throw
    {
        public Paper()
        {
            name = "Paper";
        }
        public override int Compare(string throw2)
        {
            int output = 0;
            if (throw2 == "rock" || throw2 == "Spock")
            {
                output = 1;
            }
            else if (throw2 == "Scissors" || throw2 == "Lizard")
            {
                output = 2;
            }
            return output;
        }
    }
}
