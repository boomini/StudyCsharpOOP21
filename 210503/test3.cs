using System;

namespace codingtest3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i<10; i++)
            {
                if (i == 5)
                {
                    Console.WriteLine();
                }
                for (int j=0; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
