using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Spock : Throw
    {
        public Spock()
        {
            name = "Spock";
        }
        public override int Compare(string throw2)
        {
            int output = 0;
            if (throw2 == "Scissors" || throw2 == "Rock")
            {
                output = 1;
            }
            else if (throw2 == "lizard" || throw2 == "Paper")
            {
                output = 2;
            }
            return output;
        }
    }
}
