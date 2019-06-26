using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_voting
{
    class HttpCookie
    {
        private readonly Dictionary<string, int> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, int>();
        }

        public int this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
