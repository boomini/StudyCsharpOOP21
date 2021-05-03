using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Dog : Animal
    {
        //특성 -> 속성
        public String Color { get; set; }
       
        public Dog() { this.Age = 0; this.Color = "흰색"; }
        public void Bark()
        {
            Console.WriteLine("왕왕");
        }
    }
}
