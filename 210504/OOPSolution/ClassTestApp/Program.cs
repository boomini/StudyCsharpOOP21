using System;

namespace ClassTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("고양이 객체 생성");
            Cat kitty = new Cat("키티","하얀색", 3);
            //kitty.Name = "키티";
            //kitty.Age = 3;
            kitty.Color = "하얀색";
            kitty.Meow();

            /*Cat nero = new Cat
            {
                Name = "네로",
                Age = 12,
                Color = "검은색"
            };*/

            Cat nero = new Cat("네로", 12);
            nero.Meow();

            Cat mimi = new Cat("미미", "노랑", 3);
            mimi.Meow();

            Cat coco = new Cat("코코", "얼룩이");
            coco.Age = 2;
            coco.Meow();

            Cat noname = new Cat("야옹이", "검정");
            noname.Meow();
            noname.Sleep();

            var list = (First: "Cat", Second: "Dog", Third: "Pig",55);
            Console.Write($"튜플 첫번째 : {list.First} ");
            Console.Write($"튜플 두번째 : {list.Second} ");
            Console.Write($"튜프 세번째 : {list.Third} ");
            Console.Write($"튜프 첫번째 : {list.Item4} ");
        }
    }
}
