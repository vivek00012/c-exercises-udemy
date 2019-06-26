using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_voting
{
    class UpVote
    {
        public int CurrentUpVote { get; private set; }
        private int NewVote;


        public UpVote()
        {
            this.CurrentUpVote = 0;
        }

        public int UserUpVote()
        {
            this.NewVote = this.CurrentUpVote + 1;
            return this.NewVote;
        }


    }
}
