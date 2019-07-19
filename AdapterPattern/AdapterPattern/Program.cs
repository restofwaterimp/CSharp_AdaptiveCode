using System;

namespace AdapterPattern
{
    class Program
    {
        static Adapter dependency = new Adapter();
        static void Main(string[] args)
        {
            dependency.MethodA();
        }
    }
}
