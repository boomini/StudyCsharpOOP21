using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class ExtendedMonitor
    {
        private ILogger logger;

        public ExtendedMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void PrintLog(String message)
        {
            this.logger.WriteLog(message);
        }
    }
}
