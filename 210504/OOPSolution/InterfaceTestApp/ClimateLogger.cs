using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger// Ver 1.0 개발
    {
        public void WriteError(string error)
        {
            Debug.WriteLine(error);
        }

        public void WriteLog(string weather)
        {
            Console.WriteLine($"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재날씨 {weather}");
        }
    }
}
