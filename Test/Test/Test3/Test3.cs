using System;

namespace Test3
{
    class Car
    {
        public String Name { get; set; }
        public String Maker { get; set; }
        public String Color { get; set; }
        public int YearModel { get; set; }
        public int MaxSpeed { get; set; }
        public String UniqueNumber { get; set; }

        public void Start()
        {
            Console.WriteLine($"{Name}의 시동을 겁니다.");
        }
        public void Accelerate()
        {
            Console.WriteLine($"최대시속 {MaxSpeed}km/h 로 가속합니다.");
        }
        public void TurnRight()
        {
            Console.WriteLine($"{Name}을 우회전합니다..");
        }
        public void Brake()
        {
            Console.WriteLine($"{Name}의 브레이크를 밟습니다..");
        }

    }

    class ElectricCar : Car
    {
        public void Recharge()
        {
            Console.WriteLine("전기로 배터리를 충전합니다.");
        }
    }
    class HybridCar : ElectricCar
    {
        public new void Recharge()
        {
            Console.WriteLine("달리면서 배터리를 충전합니다.");
        }
    }
    class Test3
    {
        
        static void Main(string[] args)
        {
            HybridCar ioniq = new HybridCar();
            ioniq.Name = "아이오닉";
            ioniq.Maker = "현대자동차";
            ioniq.Color = "White";
            ioniq.YearModel = 2018;
            ioniq.MaxSpeed = 220;
            ioniq.UniqueNumber = "54라 3346";

            ioniq.Start();
            ioniq.Accelerate();
            ioniq.Recharge();
            ioniq.TurnRight();
            ioniq.Brake();
        }
    }
}
