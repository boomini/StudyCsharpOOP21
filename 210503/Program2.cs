using System;

namespace CodingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("값을 입력하세요(소수점을 입력) : ");
                float input = float.Parse(Console.ReadLine());

                int ival = 10;

                Console.WriteLine($"입력된 값은 {input} 입니다");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.StackTrace}");
                throw;
            }
            
            
           /* for(int i=2; i<10; i++)
            {
                for(int j=1; j<10; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }*/
        }
    }
}
