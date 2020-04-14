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
                    string winway = WinWay(throw1,throw2);
                    
                    Console.WriteLine(p1.name + " wins the round with "+ throw1 + " " +winway+" "+ throw2);
                    
                }
                else if (win == 2)
                {
                    string winway = WinWay(throw2, throw1);
                    p2score++;
                    Console.WriteLine(p2.name + " wins the round with "+ throw2 + " " + winway + " " + throw1);

                }
                count++;
                Console.WriteLine();
                Console.WriteLine("__________");
                Console.WriteLine();
                
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
                if ( throw1 == "Rock" &&( throw2 =="Scissors" || throw2 == "Lizard" && throw1 == "Rock") )
                {
                    output = 1;
                }
                else if ( throw1 == "Rock" &&( throw2 == "Paper" || throw2 =="Spock"  ) )
                {
                    output = 2;
                }
                if (throw1 == "Paper" && (throw2 == "rock" || throw2 == "Spock" ))
                {
                    output = 1;
                }
                else if ( throw1 == "Paper" &&( throw2 == "Scissors"||throw2=="Lizard" ))
                {
                    output = 2;
                }
                if ( throw1 == "Scissors" && (throw2 == "Paper" || throw2 == "Lizard" ))
                {
                    output = 1;
                }
                else if (throw1 == "Scissors" &&( throw2 == "Rock" || throw2 == "Spock" ))
                {
                    output = 2;
                }
                if ( throw1 == "Lizard" && (throw2 == "Paper" || throw2 == "Spock" ))
                {
                    output = 1;
                }
                else if ( throw1 == "Lizard" && (throw2 == "Paper" || throw2 == "Scissors") )
                {
                    output = 2;
                }
                if ( throw1 == "Spock" && (throw2 == "Scissors" || throw2 == "Rock") )
                {
                    output = 1;
                }
                else if (throw1 == "Spock" && (throw2 == "lizard" || throw2 == "Paper") )
                {
                    output = 2;
                }



            }
            return output;

        }
        public string WinWay(string winner, string loser)
        {
            string winway = "";
            if (winner == "Rock")
            {
                winway = "crushes";              
            }
            else if (winner == "Paper")
            {
                if (loser == "Rock")
                {
                    winway = "covers";
                }
                else if (loser == "Spock")
                {
                    winway = "disproves";
                }
            }
            else if (winner == "Scissors")
            {
                if (loser == "Paper")
                {
                    winway = "cuts";
                }
                else if (loser == "Lizard")
                {
                    winway = "decapitates";
                }
            }
            else if (winner == "Lizard")
            {
                if (loser == "Spock")
                {
                    winway = "poisons";
                }
                else if (loser == "Paper")
                {
                    winway = "eats";
                }
            }
            else if (winner == "Spock")
            {
                if (loser == "Scissors")
                {
                    winway = "smashes";
                }
                else if (loser == "Rock")
                {
                    winway = "vaporizes";
                }
            }
            return winway;
        }
    }
}
