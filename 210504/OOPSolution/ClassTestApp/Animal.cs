using System;

namespace ClassTestApp
{
    class Animal
    {
        private int UniqueID { get; set; }
        protected String Name { get; set; }

        public void Eat(String meal)
        {
            Console.WriteLine($"{this.Name}이(가) {meal}를 먹습니다");
        }
        public virtual void Sleep() { Console.WriteLine($"{this.Name}이(가) 잡니다/"); }
    }
}
