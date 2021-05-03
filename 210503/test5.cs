using System;
using System.Collections.Generic;

namespace codingtest5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 3, 6, 9 };
            Console.WriteLine("3,6,9! 3,6,9! 3,6,9! 3,6,9!!");
            Console.WriteLine();
            Console.Write("짝! \t");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 15 == 0)
                {
                    Console.WriteLine();
                }
                int num1 = i / 10;
                int num2 = i % 10;
                if (num1 == 3 || num1 == 6 || num1 == 9 || num2 == 3 || num2 == 6 || num2 == 9)
                {
                    Console.Write("짝! \t");
                }
                else
                {
                    Console.Write(i + "\t");
                }

                

            }
        }
    }
}
        
    

