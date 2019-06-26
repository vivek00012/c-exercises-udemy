using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibilityandinterfaces
{

    class Program
    {
        static void Main(string[] args)
        {
            // var DbMigrator = new DbMigrator(new ConsoleLogger());
            //using extensibility gives us the privilege to change the behaviour..in this case we change to differnt implementaion using fileLogger instead of console logger
             var DbMigrator = new DbMigrator(new FileLogger(@"D:\log.txt"));

            DbMigrator.Migrate();
        }
    }
}
