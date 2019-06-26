using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_voting
{
    class DownVote
    {
        public int CurrentDownVote { get; private set; }
        private int NewDownVote;

        public DownVote()
        {
            this.CurrentDownVote = 0;
        }

        public int UserDownVote()
        {
            this.NewDownVote = this.CurrentDownVote + 1;
            return this.NewDownVote;
        }


    }
}
