using NUnit.Framework;
using AppForTest;

namespace UnitTestProject1
{
    [TestFixture]
    public class UnitTest1
    {
        MathTask m = new MathTask();

        [Test]
        public void TestMethod1()
        {
            int result = m.Adder(1, 2);
            Assert.AreEqual(3, result);
        }
    }
}
