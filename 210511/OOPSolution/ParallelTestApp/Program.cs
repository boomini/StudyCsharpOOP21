using System;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 일반적 방식
            DateTime startTime = DateTime.Now;
            for (int i=0; i<10000; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
            }
            TimeSpan procTime = DateTime.Now - startTime;
            Console.WriteLine($"for 10000 처리시간 : {procTime.TotalMilliseconds} ms");
            Console.ReadLine();

            //2.Parallel(병렬처리)
            DateTime pStartTime = DateTime.Now;
            Parallel.For(0, 10000, (i) =>
            {
                Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {i}");
            });
            TimeSpan pProcTime = DateTime.Now - pStartTime;
            Console.WriteLine($"Parallel.For 10000 처리시간 : {procTime.TotalMilliseconds} ms");
            Console.ReadLine();
        }
    }
}

