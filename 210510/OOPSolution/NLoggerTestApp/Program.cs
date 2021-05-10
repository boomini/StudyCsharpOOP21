using NLog;
using System;

namespace NLoggerTestApp
{
    class Program
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("NLog 출력!!");

            logger.Info("콘솔프로그램 시작!");
            logger.Warn("경고! 프로그램에서 ~~처리를 제대로 해야합니다.");
            logger.Error("문제발생 ! 관리자에게 문의하세요");

            Console.WriteLine("NLog 출력 완료");

        }
    }
}
