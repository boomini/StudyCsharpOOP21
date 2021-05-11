using System;
using System.Threading;

namespace ThreadLockTestApp
{

    class Counter
    {
        private int counter = 1000;
        private object thisLock = new object();
        public void Run()
        {
            for(int i=0; i<10; i++)
            {
                Thread th = new Thread(UnsafeCalc); //10개 스레드 생성
                th.Start();
            }
        }

        public void UnsafeCalc()
        {
            lock (thisLock)//lock을 통해서 동기화(다른 스레드가 접근못하도록)
            {
                counter++;
                Thread.Sleep(1);
                Console.WriteLine(counter);

            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            counter.Run();
        }
    }
    /*
     * 스레드간의 동기화
     * 멀티스레드 동기화 : 자원을 한번에 한 스레드가 사용하도록 순서를 맞추는 것
     * 
     * 동기화가 없다면?
     *  단일 연산이라고 믿었던 C# 코드도 IL로 변환해보면 복잡한 단계를 거침
     *  스레드 A가 i++를 실행하는 중에 스레드 B가 끼어들여 i++을 먼저 실행
     */
}
