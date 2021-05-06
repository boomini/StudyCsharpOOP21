using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassTestApp
{
    abstract class AbstractBase
    {
        protected void ProtectedMethod()
        {
            Console.WriteLine("AbstractBase.ProtectedMethod() 실행");
        }

        public void PublicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMethod() 실행");
        }

        public abstract void AbstractMethod(); //인터페이스 선언과 동일
    }
}
