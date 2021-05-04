using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTestApp
{
    class FileLogger : ILogger // Ver 1.2 업데이트
    {
        public void WriteError(string error)
        {
            Debug.WriteLine(error);
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"파일 txt.log에 저장 : {message}");
        }
    }
}
