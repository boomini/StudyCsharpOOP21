using System;

namespace LambdaTestApp
{
    class Program
    {
        delegate void DoSomething(String name);
        delegate String Concatenate(String[] arr);
        static void Main(string[] args)
        {
            DoSomething doIt = (name) =>
            {
                Console.WriteLine("Hello, ");
                Console.WriteLine($"{name}");
                //return //void이기때문에 생략가능

            };

            String name = "Hugo";
            doIt(name);

            Concatenate concat = (arr) =>
            {
                String result = "";
                foreach(var item in arr)
                {
                    result += item;
                }

                return result;
            };

            String[] strarr = { "아버지가", "방에", "들어가십니다." };
            Console.WriteLine(concat(strarr));

            Func<int> func1 = () => 3;

            var val1 = func1();
            Console.WriteLine($"val의 값은 {val1}");

            Func<int, int, int> plus = (x, y) => x + y;
            Console.WriteLine($"3+5={plus(3, 5)}");

            Action<int> area = (r) =>
            {
                Console.WriteLine($"원의 넓이는 {(double)r * r * Math.PI}");
            };

            area(10);
        }
    }



    /* * lambda
     * 무명함수 표현.
     * ex) calc = (a, b) => a+b;
     *
     * Func대리자 : 결과를 반환하는 메소드
     * Action대리자 : 결과를 반환하지 않는 메소드.
    */
}
