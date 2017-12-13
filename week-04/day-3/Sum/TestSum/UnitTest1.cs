using NUnit.Framework;
using Sum;
using System.Collections.Generic;

namespace TestSum
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            SumClass sum = new SumClass();
            List<int> list = new List<int> {1, 2, 3, 4 };
            int result = sum.SumList(list);
            Assert.AreEqual(10, result);
        }
    }
}
