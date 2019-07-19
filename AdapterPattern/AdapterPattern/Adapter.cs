using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : IExpectedInterface
    {
        public Adapter(TargetClass target)
        {
            this.target = target;
        }
        public void MethodA()
        {
            target.MethodB();
        }

        private TargetClass target;
    }
}
