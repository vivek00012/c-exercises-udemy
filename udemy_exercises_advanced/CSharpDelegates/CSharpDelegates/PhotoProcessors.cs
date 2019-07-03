using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDelegates
{
    public class PhotoProcessors
    {
        //creating a delegate (pointer to a method with a signature)
        //delegate uses signature
        //an instance of the delgate can hold the pointer or  function or group of funvtion that has the signature.


        //every delegate in dotnet created by delegate keyword is essentially  a class that derives from 
        //multicastdelegate or delgate
        public delegate void PhotoFilterHandler(Photo photo);

        //passing delegate to the method
        public void Process(string path,PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);

            filterHandler(photo);
            photo.Save();
        }
       
    }
}
