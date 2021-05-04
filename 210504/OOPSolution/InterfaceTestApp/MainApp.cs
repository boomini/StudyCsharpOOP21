using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("콘솔로거 사용합니다.");
            ILogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러메시지!!!!!");
            ILogger clmLogger = new ClimateLogger();
            clmLogger.WriteLog("맑음");

            ILogger filelogger = new FileLogger();
            filelogger.WriteLog("맑음");
            filelogger.WriteError("문제발생!!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("흐림//");
        }
    }
}
