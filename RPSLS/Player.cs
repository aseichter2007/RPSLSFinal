using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Transactions;

namespace RPSLS
{
    public abstract class Player
    {
        public string name;
        public List<string> throws;
        public Random random;
        public int score=0;
        public  Player()
        {
            //this.name = GetName();
            SetList();
        }
        void SetList()
        {
            throws = new List<string>() { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
        }
        //public virtual string GetName()
        //{
        //    string output="";
        //    return output;
        //}
        public abstract void SetName();
        public abstract string Throw();
        
    }
}
