using System;

namespace Test5
{
    interface IAnimal
    {
        int Age { get; set; }
        String Name { get; set; }
        
        public void Eat();
        public void Sleep();
        public void Sound();
    }
    class Dog : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} 강아지가 밥을 먹습니다");
        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} 강아지가 잠을 잡니다");

        }

        public void Sound()
        {
            Console.WriteLine($"{Name} 강아지가 소리를 냅니다. 멍멍");

        }
    }
    class Cat : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} 고양이가 밥을 먹습니다");

        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} 고양이가 잠을 잡니다");

        }

        public void Sound()
        {
            Console.WriteLine($"{Name} 고양이가 소리를 냅니다. 냥냥");

        }
    }
    class Horse : IAnimal
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public void Eat()
        {
            Console.WriteLine($"{Name} 말이 밥을 먹습니다");

        }

        public void Sleep()
        {
            Console.WriteLine($"{Name} 말이 잠을 잡니다");

        }

        public void Sound()
        {
            Console.WriteLine($"{Name} 말이 소리를 냅니다 히이잉");

        }
    }
    class Test5
    {

        static void Main(string[] args)
        {
            Cat cat = new Cat
            {
                Age = 45,
                Name = "냥냥이"
             };
            cat.Eat();
            cat.Sleep();
            cat.Sound();
            Console.WriteLine();
            Dog dog = new Dog
            {
                Age = 15,
                Name = "멍멍이"
            };
            dog.Eat();
            dog.Sleep();
            dog.Sound();
            Console.WriteLine();
            Horse horse = new Horse
            {
                Age = 5,
                Name = "망망이"
            };
            horse.Eat();
            horse.Sleep();
            horse.Sound();

        }
    }
}
