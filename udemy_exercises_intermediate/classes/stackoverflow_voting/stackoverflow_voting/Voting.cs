using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_voting
{
    class Voting
    {
        public string AskUser()
        {
            Console.WriteLine("Please Type 'UP' for UpVoting and 'DOWN' for DownVoting ");
            var UserInput = Console.ReadLine();
            switch (UserInput)
            {
                case "UP":
                    return "U";
                case "DOWN":
                    return "D";
                default:
                    return "Invalid key entered";
            }
            
        }
    }
}
