using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;
        public FileLogger(String path)
        {
            writer = File.CreateText(path); // 파일만들기
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FileLog {DateTime.Now}\t >>> {message}");
        }
    }
}
