using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    public class GenericDelegates

        //action<> and func<>
        //action<> returns a void whereas func<> returns a value
    {

        //passing delegate to the method
        public void Process(string path, Action<Photo> filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);
            photo.Save();
        }
    }
}
