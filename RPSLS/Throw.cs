using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Throw
    {
        Player p1;
        Player p2;
        public Throw(bool one)
        {
            p1 = new Human();
            p2 = new AI();
        }
        public Throw()
        {
            p1 = new Human();
            p2 = new Human();
        }
        public void Battle()
        {
            int p1score = 0;
            int p2score = 0;
            int count = 1;
            while (p1score < 3 && p2score < 3)
            {
                Console.WriteLine();
                Console.WriteLine("Round {0} Fight!",count);
                Console.WriteLine();

                string throw1 = p1.Throw();
                Console.WriteLine();
                string throw2 = p2.Throw();
                int win = ThrowCheck(throw1, throw2);
                if (win == 0)
                {
                    Console.WriteLine("Tie!");
                }
                else if (win == 1)
                {
                    p1score++;
                    Console.WriteLine(p1.name + " wins the round with "+ throw1);
                }
                else if (win == 2)
                {
                    p2score++;
                    Console.WriteLine(p2.name + " wins the round with "+ throw2);

                }
                count++;
            }
            if (p2score < p1score)
            {
                Console.WriteLine("{0} Wins!",p1.name);
            }
            else
            {
                Console.WriteLine("{0} Wins!", p2.name);
            }
        }
        public int ThrowCheck(string throw1,string throw2)
        {
            int output = 0;
            if (throw1 != throw2)
            {
                if ( throw2=="Scissors" || throw2 == "Lizard" && throw1 == "Rock" )
                {
                    output = 1;
                }
                else if (throw2 == "Paper" || throw2 =="Spock"  &&throw1 == "Rock" )
                {
                    output = 2;
                }
                if (throw2 == "rock" || throw2 == "Spock" && throw1 == "Paper")
                {
                    output = 1;
                }
                else if ( throw2 == "Scissors"||throw2=="Lizard" && throw1 == "Paper")
                {
                    output = 2;
                }
                if (throw2 == "Paper" || throw2 == "Lizard" && throw1 == "Scissors")
                {
                    output = 1;
                }
                else if (throw2 == "Rock" || throw2 == "Spock" && throw1 == "Scissors")
                {
                    output = 2;
                }
                if (throw2 == "Paper" || throw2 == "Spock" && throw1 == "Lizard")
                {
                    output = 1;
                }
                else if (throw2 == "Rock" || throw2 == "Scissors" && throw1 == "Lizard")
                {
                    output = 2;
                }
                if (throw2 == "Scissors" || throw2 == "Rock" && throw1 == "Spock")
                {
                    output = 1;
                }
                else if (throw2 == "lizard" || throw2 == "Paper" && throw1 == "Spock")
                {
                    output = 2;
                }



            }
            return output;

        }
    }
}
