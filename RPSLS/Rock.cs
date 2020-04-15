using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Rock : Throw
    {
        public Rock()
        {
            name= "Rock";
        }
        public override int Compare(string throw2)
        {
            int output = 0;
            if (throw2 == "Scissors" || throw2 == "Lizard")
            {
                output = 1;
            }
            else if (throw2 == "Paper" || throw2 == "Spock")
            {
                output = 2;
            }
            return output;
        }
    }

}
