using System;

namespace ExceptionTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("프로그램 시작!");

            int[] array = new int[5];
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    array[i] = (i + 1);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"문제발생 : {ex} 관리자 문의요망 : Main(14~)");
            }

            Console.WriteLine();
            Console.WriteLine("다른 로직 수행");

            int[] list = { 107, 108, 109 };
            try
            {
                String message = null;
                Console.WriteLine(message.Length);
                var result = list[1] / 0;
                for(int i=0; i<5; i++)
                {
                    Console.WriteLine(list[i]);
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                //IndexOutOfRange 예외시 다른일 처리
                Console.WriteLine("IndexOutOfRangeException 이후 처리!");

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("DivideByZeroException 이후 처리!");

            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");
                Console.WriteLine("NullReferenceException 이후 처리!");

            }
            catch(Exception ex)
            {
                Console.WriteLine($"예외발생 : {ex.Message}");//퉁치기
                Console.WriteLine("Exception 이후 처리!");

            }

            Console.WriteLine("프로그램 종료!");
        }
    }
}
