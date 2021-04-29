using System;
using System.Threading;
namespace ConsoleApp3
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine(ADD(5, 8));
            Console.WriteLine(ADD(15.7, 8.88));
        }
        static double ADD(double number, double number2)
        {
            return number + number2;
        }
        static int ADD(int number, int number2)
        {
            return number + number2;
        }
        static void Main27(string[] args)
        {
            Console.WriteLine(ADD(5,8));
            Console.WriteLine(ADD(15.7 , 8.88));
        }
        //메소드 오버로딩
        //메소드의 이름이 동일하고 인자의 순서나 인자의 타입이 다른 메소드를 2개이상 만든 경우
        static double ADD_Number2(double number, double number2)
        {
            return number + number2;
        }
        static void Main26(string[] args)
        {
            Console.WriteLine("Main 시작합니다");
            Console.WriteLine(ADD_Number2(24.0, 54.3));
        }
        static int ADD_Number(int number, int number2)
        {
            return number + number2;
        }
        static void Main25(string[] args)
        {
            Console.WriteLine("Main 시작합니다");
            Console.WriteLine(ADD_Number(24, 54));
        }
        static int TwoMultiple(int number, int number2)
        {
            return number * number2;
        }
        static void Main24(string[] args)
        {
            Console.WriteLine("Main 시작합니다");
            Console.WriteLine(TwoMultiple(24, 54));
        }
        static int TwoAdd(int number, int number2) 
        {
            return number + number2;
        }
        static void Main23(string[] args)
        {
            Console.WriteLine("Main 시작합니다");
            Console.WriteLine(TwoAdd(24, 54));
        }
        static void Square(int number)
        {
            Console.WriteLine("numberdml 제곱은" + (number*number) + "입니다");
        }
        static void Main22(string[] args)
        {
            Console.WriteLine("Main 시작합니다");
            Square(24);
            Console.WriteLine("Main 종료합니다");
        }
        static void AddOne(int number)
        {
            Console.WriteLine("Addone 시작합니다."+number);
        }
        static void Main21(string[] args)
        {
            Console.WriteLine("Main 시작합니다");
            AddOne(24);
        }
        static void Main20(string[] args)
        {
            Test();
            Test();
        }

        static void Test()
        {
            Console.Write("안녕하세요");
        }
        static void Main19(string[] args)
        {
            while (true)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽로 이동");
                        break;
                    case ConsoleKey.X:
                        break;
                }

            }

        }
        static void Main18(string[] args)
        {
            int x = 1;
            while (x < 50)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                if (x % 3 == 0)
                    Console.WriteLine("__@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");
                Thread.Sleep(100);
                x++;
   
            } 

        }
        static void Main17(string[] args)
        {
            Console.WriteLine("첫번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두번째 출력");
        }
        static void Main16(string[] args)
        {
            string input = "test      \n";
            Console.WriteLine("::" + input + "::");
            Console.WriteLine("::" + input.Trim() + "::");
            //trim => 공백제거

            string[] array = { "감자", "고구마", "토마토", "가지" };
            Console.WriteLine(string.Join(",", array));
        }
        static void Main15(string[] args)
        {
            string input = "감자 고구가 ,토마토";
            string[] inputs = input.Split(new char[] { ','});

            foreach (var item in inputs)
            {
                Console.WriteLine(item);
            }
        }
        static void Main14(string[] args)
        {
            string aString = "Test test TEST tEST";
            string aNewString;

            aNewString = aString.ToUpper();

            Console.WriteLine(aString);
            Console.WriteLine(aNewString);

            aNewString = aNewString.ToLower();
            Console.WriteLine(aNewString);
        }
        static void Main13(string[] args)
        {
            while (true)
            {
                Console.Write("숫자를 입력해주세요(짝수를 입력하면 종료): ");
                int input = int.Parse(Console.ReadLine());
                if (input % 2 == 0) break;

            }

            for(; ; )
            {
                Console.WriteLine("1-----1");
            }
        }
        static void Main12(string[] args)
        {
            for(int iDan = 2; iDan < 10; ++iDan)
            {
                for(int i = 1; i<10; i++)
                {
                    Console.WriteLine(iDan + "*" + i + "=" + iDan * i);
                }
            }
        }
        static void Main11(string[] args)
        {
            String[] array = { "사과", "배", "포도", "딸기", "바나나" };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }
        static void Main10(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5, 6 };

            for(int i=intArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
        static void Main9(string[] args)
        {
            String[] Test = { "바다", "하늘", "땅"};
            foreach(String i in Test)
            {
                Console.Write(i + " ");
            }
            for(int i=0; i<Test.Length; ++i)
            {
                Console.WriteLine(Test[i]);
            }
        }
        static void Main8(string[] args)
        {
            int[] iScore = { 100, 534, 325, 529, 923 };

            for (int i=0; i<iScore.Length; ++i)
            {
                Console.WriteLine
                    (iScore[i]);
            }
            foreach(int i in iScore)
            {
                Console.WriteLine (i);
            }

        }
        static void Main7(string[] args)
        {

            /*배열 선언방법
            int[] iScore = { 100,200,300};
            int[] iScore = new int[3];
            int[] iScore = new int[3] { 100, 200, 300 };*/
            int[] iScore = new int[4];
            iScore[0] = 1000;
            iScore[1] = 2000;
            iScore[2] = 3000;
            iScore[3] = 4000;
            for(int i=0; i<= iScore.Length; i++)
            {
                Console.WriteLine(iScore[i]);
            }


        }
        static void Main6(string[] args)
        {
            int[] iScore = { 100, 90, 91 };
            /*Console.WriteLine(iScore[0]);
            Console.WriteLine(iScore[1]);
            Console.WriteLine(iScore[2]);*/
            for(int i = 0; i<iScore.Length; ++i)
            {
                Console.WriteLine(iScore[i]);
            }


        }
        static void Main5(string[] args)
        {
            int iScore1 = 100;
            int iScore2 = 90;
            int iScore3 = 91;
            double dAvg;
            dAvg = (iScore3 + iScore2 + iScore1) / 3.0;

            Console.WriteLine(dAvg);
            

        }
        static void Main4(string[] args)
        {
            //0을 입력할 때까지 숫자를 입력 받아서 모두 더하는 프로그램
            int iNum=0; //입력 받은 숫자를 기억하는 변수
            int iTotal=0; // 입력 받은 숫자를 모두 누적 더하기를 한 결과
            
            
            while (true)
            {
                Console.Write("숫자를 입력해 주세요:");
                iNum = int.Parse(Console.ReadLine());
                if(iNum == 0)
                {
                    break;
                }
                iTotal += iNum;
                
            }
            Console.WriteLine("숫자의 누적합은 : "+iTotal);

            do
            {
                Console.WriteLine("숫자를 입력해주세여 : ");
                iNum = int.Parse(Console.ReadLine());
                iTotal = iTotal + iNum;
            } while (iNum != 0);
            Console.WriteLine(" 숫자의 누적합은 : " + iTotal + "입니다");

        }
        static void Main3(string[] args)
        {
            int i = 1;
            while (i <=10)
            {
                i += 1;
                if ((i % 2) != 0)
                //홀수이면
                {
                    continue;
                }
                Console.WriteLine(i);
                
            }
        }
        static void Main2(string[] args)
        {
           int i = 1;
           //for (; i<=10; )
           while(i<=10)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        static void Main1(string[] args)
        {
            //continue문 : 반복문 내부에서 사용
            for(int i =1; i<=10; i++)
            {
                if((i%2) != 0)
                //홀수이면
                {
                    continue;
                }
                Console.WriteLine(i);

            }
        }
    }
}
