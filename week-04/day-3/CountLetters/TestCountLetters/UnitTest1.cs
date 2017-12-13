using System;
using NUnit.Framework;
using CountLetters;
using System.Collections.Generic;

namespace TestCountLetters
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void Test1()
        {
            LetterCounter LC = new LetterCounter();
            Dictionary<char, int> expectedDict = new Dictionary<char, int> { { 'c', 1 }, { 'b', 2} };
            string input = "bcb";            
            Assert.AreEqual(LC.CountLetters(input), expectedDict);
        }
    }
}
