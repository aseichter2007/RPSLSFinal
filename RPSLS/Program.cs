using System;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            bool play = true;
            bool twoplay = false;
            while (play)
            {
                Console.WriteLine("how many players, 1/2");
                string players = Console.ReadLine();
                if(players == "1"|| players == "2")
                {
                    play = false;
                    if (players == "2") { twoplay = true; }
                }
                else
                {
                    Console.WriteLine("No. Again.");
                }
            }
            Throw battlefield;
            if (twoplay)
            {
               battlefield = new Throw();
            }
            else
            {
                battlefield = new Throw(twoplay);
            }
            battlefield.Battle();

            Console.ReadLine();
           
            
        }
    }
}
