using System;
using System.Threading;

namespace BasicThreadTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // DoSomething();
            Thread th1 = new Thread(DoSomething);
            th1.Start();
            th1.Interrupt(); //스레드를 WaitJoinSleep 상태일때 종단메서드...
            
            //th1.Join(); // 스레드 종료 대기
            DoOtherthing();
            //th1.Abort()// 더이상 사용안함
        }

        private static void DoOtherthing()
        {
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine($"DoOtherthing : {i}");
                Thread.Sleep(10);//10ms 대기
            }
        }

        private static void DoSomething()
        {
            for(int i=0; i<30; i++)
            {
                Console.WriteLine($"DoSomething : {i}");
                Thread.Sleep(10);

            }
        }
    }

    /* 프로세스
      - 실행파일의 데이터와 코드가 메모리에 적재되어 동작하는것.
      - word.exe가 실행 파일이라면 이 실행 파일을 실행한 것이 프로세스

      스레드(Thread)
      - 스레드는 운영체제가 CPU 시간을 할당하는 기본 단위
      - 프로세스가 밧줄이라면 스레드는 밧줄을 이루는 실

      멀티스레드
      - 한 프로세스 안에 2개 이상의 스레드를 실행하는 기법
      장점
      1. 높은 경제성
      2. 높은 사용자 응답성
      3. 용이한 데이터 교환

      단점
      1. 높은 개발 난이도
      2. 과다한 스레드는 성능 저하
      3. 스레드의 문제는 프로세스로 확산
    */
}
