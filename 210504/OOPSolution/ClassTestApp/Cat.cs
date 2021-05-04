using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTestApp
{
    class Cat : Animal
    {
        //public String Name { get; set; }
        public String Color { get; set; }
        public int Age { get; set; }

        public Cat() { /*Nothing*/}
        public Cat(String name, String color)
        {
            this.Name = name;
            this.Color = color;
            this.Age = 1;
        }
        public Cat(String color, int age)
        {
            this.Color = color;
            this.Age = age;
        }
        public Cat(string name, string color, int age)
        {
            //initialization
            this.Name = name;
            this.Color = color;
            this.Age = age;
        }
        public void Meow() 
        { 
            Console.WriteLine("{0} {1}, 야옹!",this.Color, this.Name); 
            Console.WriteLine($"{this.Color} {this.Name}, 야옹!");
        }

        public override void Sleep()
        {
            //base.Sleep(); //부모의 sleep()실행
            // 이후 자식 클래스의 sleep내용 실행
            Console.WriteLine($"{this.Color} 고양이 {this.Name}이(가) zz잡니다");
        }
    }
}
