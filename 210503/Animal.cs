using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{


    //Access Modifier : public , protected, private
    //private은상속 불가
    class Animal
    {
        protected int Age { get; set; }
        protected String Color {get; set;}

        protected Animal() { this.Age = 0; }

        protected void Eat() { Console.WriteLine("먹습니다"); }
        protected void Sleep() { Console.WriteLine("잡니다"); }

    }
}
