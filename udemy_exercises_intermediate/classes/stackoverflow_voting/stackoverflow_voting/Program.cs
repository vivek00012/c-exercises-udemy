using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_voting
{
    class Program
    {
        static void Main(string[] args)
        {
            var StackOverflowPost = new Post();
            var UpVote = new UpVote();
            var DownVote = new DownVote();
            var Voting = new Voting();
            Console.Write("Please Enter your Name: ");
            var Name = Console.ReadLine();
            Console.WriteLine(StackOverflowPost.AddPost(Name));
            Console.WriteLine();
          
               var result= Voting.AskUser();
                if (result == "U")
                {
                    Console.WriteLine("Thumbs Up :"+ UpVote.UserUpVote());
                    Console.WriteLine("Thumbs Down :"+ 0);


                }
                else if (result == "D")
                {
                    Console.WriteLine("Thumbs Up :" + 0);
                    Console.WriteLine("Thumbs Down :" + DownVote.UserDownVote());
                }
                else
                {
                    Console.WriteLine(result);
                }
        }
    }
}
