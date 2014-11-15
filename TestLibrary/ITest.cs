using System;

namespace TestLibrary
{
    public interface ITest
    {
        void TestMethod();

        int TestProperty { get; set; }

        event EventHandler TestEvent;
    }
}
