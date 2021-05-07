using System;

namespace IndexerTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MyList 예제");
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
            {
                list[i] = (i + 1);
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.WriteLine(list[i] + "\t");
            }

            Console.WriteLine("예제---------");
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
