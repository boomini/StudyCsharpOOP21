using System;

namespace GenericMyListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();
            for(int i=0; i<list.Length; i++)
            {
                list[i] = i + 1;
            }

            for(int i=0; i<list.Length; i++)
            {
                Console.Write($"{list[i]}\t");
            }

            MyList<String> strList = new MyList<string>();
            for(int i=0; i<strList.Length; i++)
            {
                strList[i] = "Hello" + (i + 1);
            }

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write($"{strList[i]}\t");
            }
            Console.WriteLine();
            MyList<Object> objList = new MyList<object>();
            objList[0] = 111;
            objList[1] = 3.141592;
            objList[2] = "Hello, world!";
            for (int i = 0; i < objList.Length; i++)
            {
                Console.Write($"{objList[i]}\t");
            }

        }
    }
}
