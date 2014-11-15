using System;
using TestLibrary;

namespace TestClient
{
    public class AnotherImplementation : ITest
    {
        public void TestMethod()
        {
        }

        public int TestProperty { get; set; }

        public event EventHandler TestEvent;
    }
}
