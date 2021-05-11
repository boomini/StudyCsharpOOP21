using System;

namespace Test2
{
    class Boiler
    {
        private byte voltage;
        private int temperature;
        public byte Voltage
        {
            get { return this.voltage; }
            set
            {
                if (value == 110 || value == 220)
                {
                    voltage = value;
                }
                else
                {
                    voltage = 32;
                }
            }
        }
        public int Temperature
        {
            get { return this.temperature; }
            set
            {
                if (value < 5)
                {
                    temperature = 5;
                }
                else if (value > 70)
                {
                    temperature = 70;
                }
                else
                {
                    temperature = value;
                }

            }


        }
        public void PrintAll()
        {
            if(Voltage == 32)
            {
                Console.WriteLine("Voltage값은 110과 220만 입력 가능합니다.");
            }
            else
            {
                Console.WriteLine($" Voltage : {this.Voltage}, Temperature : {this.Temperature}");
            }
            
        }
    }

    class Test2
    {
        static void Main(string[] args)
        {
            Boiler test1 = new Boiler { Voltage = 110, Temperature = 45 };
            Boiler test2 = new Boiler { Voltage = 220, Temperature = 4 };
            Boiler test3 = new Boiler { Voltage = 220, Temperature = 900 };
            Boiler test4 = new Boiler { Voltage = 150, Temperature = 45 };
            test1.PrintAll();
            test2.PrintAll();
            test3.PrintAll();
            test4.PrintAll();


        }
    }
}
