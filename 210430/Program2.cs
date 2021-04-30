using System;

namespace _210430_2
{
    class Car
    {
        //클래스 /static 변수
        //클래스 /static 변수
        //프로그램 시작부터 생성되어 있고
        // 프로그램 종료할 때까지 제거되지 않으며
        // 객체 (혹은 인스턴스)를 생성하지 않고 사용할 수 있는 변수
        // 모든 객체들이 공통으로 사용(단 1개만 생성)
        public static int Count = 0;

        //인스턴스 변수 : 객체가 사라지면 같이 제거되는 변수
        //객체가 생성되면 같이 생성되고,
        public int SerialNumber;
        public void SetSerial()
        {
            SerialNumber = Count;
            ++Count;
        }
    }
    class Program
    {
        class Product
        {
            public String name = "당근";
            public int price = 1000;
        }
        static void Main(String[] args)
        {
        
            Product pro= new Product();
            pro.name = "감자";
            pro.price = 1000;

            Product producta = new Product() { name = "고구마", price = 2000 };
            Console.WriteLine(pro.name + ":" + pro.price + "원");


            //지역변수 : 메서드에서 생성되면 생성되고 메서드가 종료하면 제거되는 변수
            //aCarA(객체 참조변수) : type => Car
            //aCarB(객체 참조 변수) : type => Car
            //iNum(변수) : type => int

            Car aCarA = new Car();
            aCarA.SetSerial();
            ++Car.Count;
            Console.WriteLine(Car.Count);
            Console.WriteLine(aCarA.SerialNumber);

            Car aCarB = new Car();
            aCarB.SetSerial();
            Console.WriteLine(aCarB.SerialNumber);
            ++Car.Count;
            Console.WriteLine(Car.Count);

        }
    }
}
