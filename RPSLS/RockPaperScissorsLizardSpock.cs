using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace RPSLS
{
    class RockPaperScissorsLizardSpock
    {
        public Player p1;
        public Player p2;
        public Rock rock = new Rock();
        public Paper paper = new Paper();
        public Scissors scissors = new Scissors();
        public Lizard lizard = new Lizard();
        public Spock spock = new Spock();
        public RockPaperScissorsLizardSpock(bool one)
        {
            p1 = new Human();
            p2 = new AI();
        }
        public RockPaperScissorsLizardSpock()
        {
            p1 = new Human();
            p2 = new Human();
        }
        public void Battle()
        {
            int count = 1;
            do
            {
                Round(count);
                string throw1 = p1.Throw();
                Space();
                string throw2 = p2.Throw();
                int win = ThrowCheck(throw1, throw2);
                Win(win, throw1, throw2);
                count++;
                Space();
            }
            while (p1.score < 3 && p2.score < 3);

        }
        public int ThrowCheck(string throw1, string throw2)
        {
            int output = 0;
            if (throw1 != throw2)
            {
                switch (throw1)
                {
                    case "Rock":
                        output = rock.Compare(throw2);                      
                        break;

                    case "Scissors":
                        output = scissors.Compare(throw2);
                        break;

                    case "Paper":
                        output = paper.Compare(throw2);
                        break;

                    case "lizaed":
                        output = lizard.Compare(throw2);
                        break;

                    case "Spock":
                        output = spock.Compare(throw2);
                        break;
                }
            }
            return output;           
        }
         string WinWay(string winner, string loser)
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
        
        public void Win(int win, string throw1, string throw2)
        {
            if (win == 0)
            {
                Console.WriteLine("Tie!");
            }
            else if (win == 1)
            {
                p1.score++;
                string winway = WinWay(throw1, throw2);

                Console.WriteLine(p1.name + " wins the round. " + throw1 + " " + winway + " " + throw2);

            }
            else if (win == 2)
            {
                string winway = WinWay(throw2, throw1);
                p2.score++;
                Console.WriteLine(p2.name + " wins the round. " + throw2 + " " + winway + " " + throw1);

            } 
        }
        public void Space()
        {
            Console.WriteLine();
            Console.WriteLine("__________");
            Console.WriteLine();
            Console.WriteLine();
        }
        public void Round(int count)
        {
            Console.WriteLine();
            Console.WriteLine("Round {0} Fight!", count);
            Console.WriteLine();
        }
        
        
    }
}
