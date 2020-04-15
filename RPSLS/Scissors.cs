using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RPSLS
{
    class Scissors : Throw
    {
        public Scissors()
        {
            name = "scissors";
        }
        public override int Compare(string throw2)
        {
            int output = 0;
            if (throw2 == "Paper" || throw2 == "Lizard")
            {
                output = 1;
            }
            else if (throw2 == "Rock" || throw2 == "Spock")
            {
                output = 2;
            }
            return output;
        }

    }
}
