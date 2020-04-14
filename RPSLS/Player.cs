using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Transactions;

namespace RPSLS
{
    class  Player
    {
        public string name;
        public List<string> throws;
        public Random random;
        public  Player()
        {
            //this.name = GetName();
            this.throws = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

        }
        public virtual string GetName()
        {
            string output="";
            return output;
        }
        public virtual string Throw()
        {
            string output = "";
            bool throwCheck = true;
            while (throwCheck)
            {
                for (int i = 0; i < throws.Count; i++)
                {
                    Console.WriteLine( i+1 +  ". " +throws[i]);
                }
                Console.WriteLine("Choose your destiny in the form of a number");
                output = Console.ReadLine();
                if (output == "1" || output == "2" || output == "3" || output == "4" || output == "5")
                {
                    throwCheck = false;
                }
                else
                {
                    Console.WriteLine("You dummy, that isnt a singe integer between one and 5");
                }

            }

            output = throws[int.Parse(output)-1];
            return output;
        }
    }
}
