using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTest
{
    class Cat : Animal
    {
        //특성 -> 속성
        public String Color { get; set; }

        public Cat() { this.Age = 0;  }
        public void Meow()
        {
            Console.WriteLine("냥냥");
        }
    }
}
