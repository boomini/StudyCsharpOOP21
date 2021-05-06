using System;

namespace AbstractClassTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.PublicMethod();
            obj.AbstractMethod();
        }
    }
}
