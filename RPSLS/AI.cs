using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class AI : Player
    {
        public AI()
        {
            random = new Random();
            name = GetName();
            //throws = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        public override string GetName()
        {
            List<string> name = new List<string>() { "Mike Rowe Bot", "Dwayne 'The Rock' Johnson", "Mr T", "Data", "Michael Terrill", "Brett Johnson", "Charles King", "David Lagrange", "Michael Heinisch", "Nevin Seibel" };

             int rand = random.Next(0, name.Count - 1);
            string output = name[rand];
            return output;        
        }
        public override string Throw()
        {

            string output = throws[random.Next(0, throws.Count - 1)];
            return output;
        }
    }
}
