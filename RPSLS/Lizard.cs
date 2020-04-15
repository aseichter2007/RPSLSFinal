using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace RPSLS
{
    class Lizard : Throw
    {
        public Lizard()
        {
            name = "Lizard";
        }
        public override int Compare(string throw2)
        {
            int output = 0;
            if (throw2 == "Paper" || throw2 == "Spock")
            {
                output = 1;
            }
            else if (throw2 == "Rock" || throw2 == "Scissors")
            {
                output = 2;
            }
            return output;
        }
    }
}
