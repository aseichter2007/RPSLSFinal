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
            SetName();
            //throws = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        public override void SetName()
        {
            List<string> names = new List<string>() { "Mike Rowe Bot", "Dwayne 'The Rock' Johnson", "Mr T", "Data", "Michael Terrill", "Brett Johnson", "Charles King", "David Lagrange", "Michael Heinisch", "Nevin Seibel" };

             int rand = random.Next(0, names.Count - 1);
            name = names[rand];      
        }
        public override string Throw()
        {

            string output = throws[random.Next(0, throws.Count - 1)];
            return output;
        }
    }
}
