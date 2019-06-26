using System;
using System.IO;

namespace Extensibilityandinterfaces
{


    public class FileLogger : Ilogger {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }

        //instatiating path via constructor
      
    
        public void LogError(string message)
        {
            log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            log(message, "INFO");

        }

        public void log(string message,string messageType)
        {
            //when using block is used the compiler automatically include a call to dispose method
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType+":"+message);
            }
        }
    }
}
