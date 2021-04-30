using System;

namespace ConsoleApp4
{

    class Car
    {
        //제조사
        public string Vender;
        //속도
        public int speed;
        public int speed2;
        int speed3;
        //public 사용하지 않으면 class 밖에서 접근할 수 없다.
        
        public void Accel(int speed)
        {
            speed += 10;
        }
        public void Break(int speed)
        {
            speed -= 10;
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            int[] Array1 = { 3, 4, 5 };
            foreach(int Temp in Array1)
            {
                Console.WriteLine(Temp);
            }
        }
        static void Main2(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            car1.Vender = "현대";
            car2.Vender = "테슬라";
            car1.speed = 0;
            car2.speed = 0;

            Console.WriteLine(car1.Vender + car2.Vender);
            Console.WriteLine("car1 현재 속도는 " + car1.speed + "Km입니다");
            Console.WriteLine("car2 현재 속도는 " + car2.speed + "Km입니다");
        }
    }
}
