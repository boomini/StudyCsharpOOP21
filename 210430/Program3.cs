using System;
using System.Collections.Generic;

namespace _210430_3
{


    //상속
    class Bus : car1
    {
        public Bus()
        {
            Console.WriteLine("버스 객체가 생성되었습니다.");
        }

    }
    class car1
    {
        private String Vender;
        private int Speed;
        //speed는 accel과 break로만 제어할 수 있다.
        // 외부에서는 veder와 speed를 바꿀 수 있는 방법이 존재하지 않는다.


        //this() 자체의 다른 함수를 호출할떄 
        public car1() : this("미정")
        {
            Console.WriteLine("카 객체가 생성되었습니다.");
        }
        public car1(String aVender)
        {
            Vender = aVender;
            Speed = 0;
        }

        public void Accel()
        {
            
            Speed += 10;
            if (Speed > 30)
            {
                Speed = 30;
            }
        }

        public void Break()
        {
            Speed -= 10;
            if(Speed < 0)
            {
                Speed = 0;
            }
        }

        public void Status()
        {
            Console.WriteLine("[ 제조사 : " + Vender + "] [속도: "+Speed +"]");
        }
    }
    //특별한 메서드 : 생성자
    //1. 메서드와 비슷
    //2. 반환값이 없다.(void를 사용하지 않음)
    //3. 메서드 이름은 반드시 클래스이름을 사용.
    //4. 생성될 때 자동으로 호출된다.

    //특별한 메서드2 : 소멸자
    //1. 생성자와 비슷
    //2. 이름앞에 ~(틸드)를 붙임
    //3. public 불가
    //4. 소멸자는 1개만 만들 수 있음
    class Car
    {
        public String Vender;
        public int speed;

        public Car() //생성자 : 디폴트 생성자(인자가 없는 생성자)
        {
            Console.WriteLine("나는 default 생성자다");

        }
        public Car(int inum)
        {
            Console.WriteLine("나는 생성자다" + inum);
        }
         ~Car() //소멸자
        {
            Console.WriteLine("나는 소멸자다");

        }
    }
    class Student
    {
        public String name;
        public int grade;
    }
    class Smart
    {
        public static String name = "스마트 팩토리";
    }
    class Program
    {
        static void Main(string[] args)
        {/*
            car1 aCar1 = new car1();
            car1 aCar2 = new car1("테슬라");
            aCar1.Status();
            aCar2.Status();*/

            Bus aBus = new Bus();

        }
        static void Main6(string[] args)
        {
            Console.WriteLine("----------------------1");
            Car acar = new Car(5);
            Console.WriteLine("----------------------2");

        }
        static void Main5(string[] args)
        {
            List<Student> aLIst;
            aLIst = new List<Student>();

            Student aStudent = new Student() { name = "강감찬 장군", grade = 1 };
            aLIst.Add(aStudent);
            aStudent = new Student() { name = "광개토대왕 장군", grade = 1 };
            aLIst.Add(aStudent);
            aStudent = new Student() { name = "세종대왕", grade = 1 };
            aLIst.Add(aStudent);
            aStudent = new Student() { name = "이순신 장군", grade = 1 };
            aLIst.Add(aStudent);
            aStudent.grade = 100;

            Console.WriteLine(aLIst[0].name + aLIst[1].name + aLIst[2].name);
        }
        static void Main4(string[] args)
        {
            Student aStudent1 = new Student() { name = "광개토 대왕", grade = 1 };
            Student aStudent2 = new Student() { name = "세존 대왕", grade = 2 };
            Student aStudent3 = new Student() { name = "이순신 장군", grade = 3 };
            Student aStudent4 = new Student() { name = "강감찬 장군", grade = 4 };

        }
        static void Main2(string[] args)
        {
            Console.WriteLine("1번 학생은 " + Smart.name + "반 홍길동입니다.");
            Console.WriteLine("1번 학생은 " + Smart.name + "반 고길동입니다.");
            Console.WriteLine("1번 학생은 " + Smart.name + "반 한길동입니다.");
            Console.WriteLine("반지름이 10인 원의 넓이는 " + (10 * 10 * Math.PI) + "입니다");

            List<Student> list = new List<Student>();
            list.Add(new Student() { name = "윤인성", grade = 1 });
            list.Add(new Student() { name = "연하진", grade = 2 });
            list.Add(new Student() { name = "윤아린", grade = 3 });
            list.Add(new Student() { name = "윤명월", grade = 4 });
            list.Add(new Student() { name = "구지원", grade = 1 });
            list.Add(new Student() { name = "김연화", grade = 2 });

            foreach (var item in list)
            {
                if(item.grade > 1)
                {
                    list.Remove(item);
                }
            }

            foreach(var item in list)
            {
                Console.WriteLine(item.name + " : " + item.grade);
            }
        }

        static void Main3(string[] args)
        {
            Student[] array;
            array = new Student[4];
            Student student ;
            student = new Student() { name = "광개토 대왕", grade = 2 };
            array[0] = new Student();
            array[0].name = "강감찬 장군";
            array[0].grade = 1;

            array[1] = student;
            student = new Student() { name = "세존 대왕", grade = 2 };
            array[2] = student;
            student = new Student() { name = "이순신 장군", grade = 2 };
            array[3] = student;

            Console.WriteLine(array[0].name + array[1].name +array[2].name);

            array[1] = null;
        }
    }
}
