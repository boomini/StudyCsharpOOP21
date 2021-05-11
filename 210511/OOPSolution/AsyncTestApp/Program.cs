using System;
using System.Threading.Tasks;

namespace AsyncTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Caller();
        }

        private static void Caller()
        {
            Console.WriteLine("Caller A");
            Console.WriteLine("Caller B");
            MyMethodAsync(3); //비동기처리
            Console.WriteLine("Caller E");
            Console.WriteLine("Caller F");

        }

        async private static void MyMethodAsync(int count)
        {
            Console.WriteLine("My C");
            Console.WriteLine("My D");

            await Task.Run(async () =>
            {

                for (int i = 1; i <= count; i++)
                {
                    Console.WriteLine($"{i}/{count}...");
                }
            });
            
            Console.WriteLine("My G");
            Console.WriteLine("My H");

        }
    }
    /*
 * async 한정자
 *  - async 한정자는 메소드, 이벤트 처리기, 태스크, 람다식 등을 수식함
 *  - C# 컴파일러가 async 한정자로 수식한 코드의 호출자를 만날 때 호출결과를 기다리지 않고 
 *  바로 다음 코드로 이동하도록 실행 코드를 생성
 *  
 *  async로 한정하는 메소드는 반환 형식이 Task나 Task<TResult>, 또는 void 여야함
 *   - async로 메소드/태스크/람다식은 await연산자를 만나는 곳에서 호출자에게 제어 반환
 *   - await 연산자가 없는 경우엔 동기로 실행.
 * */
}
