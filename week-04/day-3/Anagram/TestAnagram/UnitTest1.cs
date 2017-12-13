using System;
using NUnit.Framework;
using Anagram;

namespace TestAnagram
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1([Values("Hitler woman", "Mother-in-law")] string inputs)
        {
            AnagramMethod anagram = new AnagramMethod();
            string input = "mother-in-law";
            Assert.True(anagram.IsAnagram(input, inputs));
        }
    }
}
