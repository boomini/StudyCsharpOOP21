using System;

namespace Test1
{
    class Boiler
    {
        public string Brand { get; set; }
        public int Voltage { get; set; }
        public int Temperature { get; set; }

        public void PrintAll()
        {
            Console.WriteLine($"Brand : {Brand} , Voltage : {Voltage}, Temperature : {Temperature}");
        }
    }

    class Test1
    {
        
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler { Brand = "귀뚜라미", Voltage = 220, Temperature = 45 };
            kitturami.PrintAll();
        }
    }
}
