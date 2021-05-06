using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTestApp
{
    class Dog
    {
        private int age;
        //private String name;

        public String Name { get; set; } = "멍멍이";//초기값 지정
        public String Color { get; set; } = "누런";
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value < 0)
                {
                    this.age = 1;
                }
                else if(value > 15)
                {
                    this.age = 15;
                }
                else
                {
                    this.age = value;
                }
                
            }
        }

      /*  public String GetName() { return this.name; }
        public void SetName(String name) { this.name = name; }
        //값을 사용
        public String GetAge() { return $"{this.age}세"; }
        //값을 설정
        public void SetAge(int age) {
            if (age < 0)
            {
                this.age = 1;
            }
            else if (age > 15)
            {
                this.age = 15;
            }
            else
            {
                this.age = age;
            }
        }*/
    }
}
