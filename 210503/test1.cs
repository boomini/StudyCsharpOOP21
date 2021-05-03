using System;

namespace codingtest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("원의 반지름을 입력하세요: ");
            int input = int.Parse((Console.ReadLine()));

            Console.Write("원의 넓이는 " + input * input * Math.PI);

        }
    }
}
