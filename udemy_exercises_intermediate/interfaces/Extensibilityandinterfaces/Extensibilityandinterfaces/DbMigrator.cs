using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensibilityandinterfaces
{
    public class DbMigrator
    {
        private readonly Ilogger _Ilogger;

        public DbMigrator(Ilogger _Ilogger)
        {
            this._Ilogger = _Ilogger;
        }

        public void Migrate()
        {
            _Ilogger.LogInfo("Migrating Started at " + DateTime.Now);
            _Ilogger.LogInfo("Migrating Ended at " + DateTime.Now);

        }


    }
}
