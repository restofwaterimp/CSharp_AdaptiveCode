using System;

namespace AdapterPattern
{
    class Program
    {
        static IExpectedInterface dependency = new Adapter(new TargetClass());
        //static Adapter dependency = new Adapter();
        static void Main(string[] args)
        {
            dependency.MethodA();
        }
    }
}
