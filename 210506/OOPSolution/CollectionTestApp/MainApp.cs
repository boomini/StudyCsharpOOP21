using System;
using System.Collections;

namespace CollectionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList 예제");
            int a = 123;
            Object obj = a;
            Console.WriteLine("a의 타입 : "+a.GetType());
            Console.WriteLine("obj의 타입: " + obj.GetType());

            String str = "문자열임";
            obj = str;

            Console.WriteLine("str의 값 : " + str);
            Console.WriteLine("obj의 값: " + obj);
            //------------------------------------------
            ArrayList list = new ArrayList(); // 사이즈 지정x
            list.Add(3);
            list.Add(67);
            list.Add(1);
            list.Add(30);
            list.Add(14);

            list.Sort();
            foreach(var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            list.Reverse();
            foreach(var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            list.Insert(2, 88);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            list.RemoveAt(5);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();
            list.Add(100);
            int index100 = list.IndexOf(100);
            Console.WriteLine($"100의 위치 : {index100}");

            list.Add(14);
            foreach (var item in list)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            int index14 = list.IndexOf(14);
            Console.WriteLine($"14의 위치값 : {index14}");

            int lstIndex14 = list.LastIndexOf(14);
            Console.WriteLine($"마지막 14의 위치값: {lstIndex14}");

            Console.WriteLine($"총갯수 {list.Count}");
            Console.WriteLine($"리스트 마지막값 {list[list.Count - 1]}");
        }
    }
}
