using System;

namespace DelegateChainApp
{
    delegate int Calculate(int a, int b);
    class MainApp
    {
        static void Main(string[] args)
        {
            #region
            FireStation station = new FireStation();
            ThereIsAFire fireHouse = new ThereIsAFire(station.Call119);
            fireHouse += new ThereIsAFire(station.ShotOut);
            fireHouse += new ThereIsAFire(station.Escape);
            fireHouse("우리집");
            //대리자의 장점 : 한꺼번에 여러개의 함수를 실행시킬 수 있다.

            Console.WriteLine();

            ThereIsAFire fireWoorim = new ThereIsAFire(station.Call119);
            fireWoorim += new ThereIsAFire(station.Escape);
            //대리자 실행
            fireWoorim("우림라이온밸리A");
            #endregion

            Calculate calc;
            calc = delegate (int a, int b)
            {
                return a + b;
            };
            Console.WriteLine($"a+b = {calc(3, 5)}");
        }
    }
}
