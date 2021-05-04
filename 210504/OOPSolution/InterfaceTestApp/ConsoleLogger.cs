using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger// Ver 1.0 개발
    {
        public void WriteError(string error)
        {
            Debug.WriteLine(error);
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"로그 {DateTime.Now}: {message}");
        }
    }
}
