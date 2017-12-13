using NUnit.Framework;
using Fibonacci;

namespace TestFibonacci
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            FibonacciCalculator calc = new FibonacciCalculator();
            int input = 10;
            int expectedOutput = 55;
            int actualOutput = calc.ComputeFibonacci(input);
            Assert.AreEqual(expectedOutput, actualOutput);
        }
    }
}
