using NUnit.Framework;
using Apple;

namespace TestApple
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestMethod1()
        {
            AppleClass apple = new AppleClass();

            string output = apple.GetApple();

            Assert.AreEqual("Apple", output);

        }
    }
}
