using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandlerTestApp
{
    delegate void EventHandler(String message); // 대리자 선언
    class MyNotifier
    {
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            int temp1 = number % 10;
            int temp2 = number / 10;
            if (temp1 != 0 && temp1 % 3 == 0 || temp2 %3 ==0 && temp2 != 0)
            {
                SomethingHappened($"짝 ");

            }
            else
            {
                SomethingHappened($"{number}\t");
            }
        }
    }
}
