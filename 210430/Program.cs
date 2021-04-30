using System;
using System.Collections.Generic;

namespace _210430
{
    class Program
    {
        class Test
        {
            public int Power(int x)
            {
                return x * x;
            }
        }
        
        class Test2
        {
            public int Multi(int x, int y)
            {
                return x * y;
            }
        }
        class Test3
        {
            public void Print()
            {
                Console.WriteLine("Print() 메소드가 호출되었습니다");
            }
        }
        
        class Test4
        {
            public int Sum(int min, int max)
            {
                int output = 0;
                for(int i = min; i<=max; i++)
                {
                    output += i;
                }
                return output;
            }
        }

        class Test5
        {
            public int Multiply(int min, int max)
            {
                int output = 1;
                for(int i=min; i<=max; i++)
                {
                    output *= i;
                }
                return output;
            }
        }
        static void Main(string[] args)
        {
            Product aProduct = new Product();

        }
        static void Main4(string[] args)
        {
            Console.WriteLine(Math.Abs(-52273));
            Console.WriteLine(Math.Ceiling(52.273));
            Console.WriteLine(Math.Floor(52.273));
            Console.WriteLine(Math.Max(52,273));
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));

        }
        static void Main3(string[] args)
        {
            List<int> aList = new List<int>();

            aList.Add(52);
            aList.Add(32);
            aList.Add(275);
            aList.Add(64);
            aList.Add(11);

            foreach(var item in aList)
            {
                Console.WriteLine("Count: " + aList.Count + "\titem: " + item);
            }
            aList.RemoveAt(1);
            //1번위치(2번째)의 자료를 삭제
            aList.Remove(11);
            //11을 찾아서 삭제
            foreach (var item in aList)
            {
                Console.WriteLine("Count: " + aList.Count + "\titem: " + item);
            }

        }
        static void Main2(string[] args)
        {
            Test test = new Test();
            Test2 test2 = new Test2();
            Test3 test3 = new Test3();
            Console.WriteLine(test.Power(10));
            Console.WriteLine(test.Power(20));
            Console.WriteLine(test2.Multi(52, 273));
            Console.WriteLine(test2.Multi(103, 32));
            test3.Print();
            test3.Print();

            Test4 test4 = new Test4();
            Console.WriteLine(test4.Sum(1, 100));

            Test5 test5 = new Test5();
            Console.WriteLine(test5.Multiply(1, 10));

            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.Next(10, 100));
        }
    }
}
