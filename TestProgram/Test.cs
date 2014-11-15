using System;
using TestLibrary;

namespace TestProgram
{
    public class Test : ITest
    {
        public void TestMethod()
        {
            
        }

        public int TestProperty { get; set; }

        public event EventHandler TestEvent;
    }
}
