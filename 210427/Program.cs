using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  *  *      *");
            Console.WriteLine("    *  *  ********");
            Console.WriteLine("    *  *  *      *");
            Console.WriteLine("    *  *  ********");
            Console.WriteLine("********      *   ");
            Console.WriteLine("*      *      *   ");
            Console.WriteLine("*      *      *   ");
            Console.WriteLine();
            //enter만 넣고 싶을때
            Console.WriteLine("********  ********");
            Console.WriteLine("지옥으로 키티");
            Console.Write("지옥으로"); 
            Console.Write("키티");

            //정수
            Console.WriteLine(100 + 200);
            Console.WriteLine(100 - 200);
            Console.WriteLine(100 * 200);
            Console.WriteLine(100 / 200);
            Console.WriteLine(100 % 200);

            Console.WriteLine("\t유후\t\"나니\"");
            Console.WriteLine("간나다" + "라마" + "바사");

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);


            int a = 23423;
            Console.WriteLine(a);

            a = 2147483647;
            int b = 1;
            Console.WriteLine(a);
            Console.WriteLine(a + b);

            double c = 52.263;
            float d = 103.32f;
            //그냥 실수를 적으면 double로 간주한다. 정수는 int로 간주.'

            char e,f;
            e = 'a';
            f = (char)44032;        
            Console.WriteLine(f);

            bool one = 10 < 0;
            bool other = 20 > 100;

            Console.WriteLine(one);
            Console.WriteLine(other);

            int number = 10;
            number++;
            Console.WriteLine(number);
            number--;
            Console.WriteLine(number);
        }
    }
}
