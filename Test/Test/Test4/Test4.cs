using System;
using System.Collections.Generic;

namespace Test4
{
    class Test4
    {
        static void Main(string[] args)
        {
            Dictionary<String, string> color = new Dictionary<string, string>();
            color["Red"] = "빨간색";
            color["Orange"] = "주황색";
            color["Yellow"] = "노란색";
            color["Green"] = "초록색";
            color["Blue"] = "파란색";
            color["Indigo"] = "남색";
            color["Purple"] = "보라색";
            Console.Write("무지개 색은 ");
            foreach(var item in color)
            {
                Console.Write($"{item.Value}, ");
            }
            Console.WriteLine("입니다");
            Console.WriteLine("Key와 Value확인");
            Console.WriteLine($"Purple은 {color["Purple"]} 입니다.");

        }
    }
}
