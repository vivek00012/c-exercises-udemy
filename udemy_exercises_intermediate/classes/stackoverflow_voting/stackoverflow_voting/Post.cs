using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stackoverflow_voting
{
    class Post
    {
        public string Title { get; private set; }
        public string Time { get; private set; }
        public string Description { get; private set; }


        public string AddPost(string name)
        {
            Console.WriteLine("Please Provide title for the post :");
            var InputTitle = Console.ReadLine();
            Console.WriteLine("Please Provide Description for the post :");
            var InputDescription = Console.ReadLine();

            this.Title = InputTitle;
            this.Time = string.Format("{0} at {1}",DateTime.Now.ToShortDateString(),DateTime.Now.ToLongTimeString());
            this.Description = InputDescription;

            Console.Clear();
            Console.WriteLine(this.Title);
            Console.WriteLine();
            Console.WriteLine(this.Description);
            var Post= string.Format(@"Posted By {0}         {1}    ", name, this.Time);
            return Post;
        }

    }
}
