using System;

namespace DelegateTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine($"3 + 5 = {calc.Plus(3, 5)}");
            Console.WriteLine($"3 / 5 = {calc.Divide(3, 5)}");

            //대리자 호출
            CalcDelegate callBack;
            callBack = new CalcDelegate(calc.Plus);
            Console.WriteLine($"3 + 5 = {callBack(3, 5)}");

            callBack = new CalcDelegate(calc.Multiple);
            Console.WriteLine($"3 x 5 = {callBack(3, 5)}");

        }
    }
}
