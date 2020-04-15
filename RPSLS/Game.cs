using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    class Game
    {
        RockPaperScissorsLizardSpock battlefield;       

        public void Rungame()
        {
            string exit = "";
            do
            {
                string humans = Setplayers();
                battlefield.Space();
                DeclarePlayers();
                battlefield.Space();
                battlefield.Battle();
                Winner();
                Console.WriteLine("New Game?   Type exit to exit");
                exit = Console.ReadLine();
            }
            while (exit != "exit");

        }
        public string Setplayers()
        {
            bool check = false;
            string players;
            do
            {
                Console.WriteLine("how many players, 1/2");
                players = Console.ReadLine();
                if (players == "1" || players == "2")
                {
                    CreateGame(players);
                    check = true;
                }
                else
                {
                    Console.WriteLine("No. Again.");
                }
            }
            while (check == false);

                return players;

        }
        public void CreateGame(string players)
        {            
            if (players == "2")
            {
                battlefield = new RockPaperScissorsLizardSpock();
            }
            else
            {
                battlefield = new RockPaperScissorsLizardSpock(true);
            }
        }
        public void Winner()
        {
            if (battlefield.p2.score < battlefield.p1.score)
            {
                Console.WriteLine("{0} Wins!", battlefield.p1.name);
            }
            else
            {
                Console.WriteLine("{0} Wins!", battlefield.p2.name);
            }
        }
        public void DeclarePlayers()
        {
            Console.WriteLine("{0}", battlefield.p1.name);
            Console.WriteLine("and");
            Console.WriteLine("{0}", battlefield.p2.name);
            Console.WriteLine("Have entered the arena.");
        }
    }
}
