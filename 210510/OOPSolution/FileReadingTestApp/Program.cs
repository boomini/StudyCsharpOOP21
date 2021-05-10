using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String fullPath = @"C:\Test\Help\mui\0412\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open ));

            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close();
            //open하면 반드시 close해주어야 한다.
            //텍스트파일 읽어오는 부분



            String writePath = @"C:\Test\Help\SMG.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));
            sw.Write("Hello, World!\n");
            sw.Write("안녕하세요\n");
            sw.Write(3.141592f);

            sw.Close();

            Console.WriteLine("텍스트파일 작성완료!!");
        }
    }
    /*
         Stream : 영어로 시내, 강, 또는 도로의 차선을 뜻함
         I/O에 있어 스트림은 "데이터가 흐르틑 통로"를 뜻함
         예) 메모리에서 하드디스크로 데이터 전송시 스트림으로 둘 사이를 연결 후, 데이터를 바이트 단위로 전송.
         
         System.IO.Stream. 클래스
         - 입력 스트림, 출력 스트림의 역할을 모두 수행
         - 순차접근방식과 임의 접근방식(안쓰는게 좋다)모두 지원
         - 단, 추상 클래스이기 때문에 이 클래스의 인스턴스를 직접 만들어 사용할 수는 없고 이 클래스로부터 파생된 클래스를 사용해야한다.
         
         */
}
