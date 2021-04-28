using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=9; i++)
            {
                Console.WriteLine("2 * "+ i+ " = "+ 2 * i);

            }

        }
        static void Main17(string[] args)
        {
           for(int i=1; i<11; i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }
            
        }
        static void Main16(string[] args)
        {
            ConsoleKeyInfo info = Console.ReadKey();
            switch (info.Key)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("위로이동");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("오른쪽으로 이동");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("왼쪽으로 이동");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("아래로 이동");
                    break;
                default:
                    Console.WriteLine("다른키를 눌렀습니다.");
                    break;

            }
        }
        static void Main15(string[] args)
        {
            Console.Write("입력: ");
            String line = Console.ReadLine();

            if (line.Contains("안녕"))
            {
                Console.WriteLine("안녕하세요...!");
            }
            else
            {
                Console.WriteLine("^^");
            }
        }
        static void Main14(string[] args)
        { int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");
        }
        static void Main13(string[] args)
        {
            Console.Write("점수를 입력하세요:");
            int iScore = int.Parse(Console.ReadLine());
            char grade;
            iScore = iScore / 10;
            switch (iScore)
            {
                case 10:
                case 9:
                    grade = 'A';
                    break;
                case 8:
                case 7:
                    grade = 'B';
                    break;
                default:
                    grade = 'F';
                    break;


            }
            Console.WriteLine(grade);
        }
        static void Main12(string[] args)
        {
            Console.Write("점수를 입력하세요:");
            int iScore = int.Parse(Console.ReadLine());
            char grade ;
            iScore = iScore / 10;
            switch (iScore)
            {
                case 10:
                case 9:
                    grade = 'A';
                    break;
                case 8:
                case 7:
                    grade = 'B';
                    break;
                default:
                    grade = 'F';
                    break;
                

            }
            Console.WriteLine(grade);
        }
        static void Main11(string[] args)
        {
            Console.Write("이번 달은 몇 월인가요:");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("대체 어떤 행성에 살고 계신가요");
                    break;
                 
            }
        }
        static void Main10(string[] args)
        {
            Console.Write("점수를 입력하세요:");
            int iScore = int.Parse(Console.ReadLine());
            char grade = 'F';
            if (iScore >=  90)
            {
                grade = 'A';
            }
            else if(iScore >= 80)
            {
                grade = 'B';
            }
            else if(iScore >= 70)
            {
                grade = 'C';
            }
            else if(iScore >= 60)
            {
                grade = 'D';
            }
            Console.WriteLine(grade);
        }
        static void Main9(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else
            {
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }
        }
        static void Main8(string[] args)
        {
            int Number = int.Parse(Console.ReadLine());
            int iResult;
            bool bResult;
            iResult = (Number % 2);
            bResult = (iResult == 0);

            if (bResult)
            {
                Console.WriteLine(Number + "는 짝수입니다");
            }
            else
            {
                Console.WriteLine(Number + "는 홀수입니다");
            }
        }
        static void Main7(string[] args)
        {
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }
            if(12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다");
            }

            Console.WriteLine(DateTime.Now.ToString("hh"));
        }
        static void Main6(string[] args)
        {
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
        }


        static void Main5(string[] args)
        {
            Console.WriteLine("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }
            if(input % 2 == 1)
            {
                Console.WriteLine("홀수입니다!");
            }


        }
        static void Main4(string[] args)
        {
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));
            Console.WriteLine(number.ToString("0.00000"));
            Console.WriteLine(number.ToString("0.000000"));
            
            //반올림한다. type casting이 아니다.

        }
        static void Main3(string[] args)
        {
            string numberString = "52273";
            //int intNumber = (int)numberString;
            //문자열형태는 이런식으로 숫자로 바꿀 수 없다. 함수사용!
            int intNumber = int.Parse(numberString);
            Console.WriteLine(intNumber);

        }
        static void Main2(string[] args)
        {
            char Text = '가';
            Console.WriteLine("Text=" + Text);
            Console.WriteLine("Text=" + (int)Text);
            Console.WriteLine("43032-" + 44032);
            Console.WriteLine("43032=" + (char)44032);

        }
        static void Main1(string[] args)
        {
            var Number = 100;
            Console.WriteLine(Number);
            String input = Console.ReadLine();
            Console.WriteLine("input : " + input);

            Console.Write("글자를 입력하세요 : ");
            String input2 = Console.ReadLine();
            Console.WriteLine(input2);

            float fNumber;
            int iNumber = 100;
            fNumber = iNumber; // 자동 형변환
            iNumber = (int)fNumber; //수동 형변환
            Console.WriteLine(iNumber);
            
            char Text = '가';
            Console.WriteLine(Text);

            int Number2 = Text;
            Console.WriteLine(Number2);

            int Number3 = 44032;
            char Text2 = (char)Number3;
            Console.WriteLine(Text2);
        }
    }
}
