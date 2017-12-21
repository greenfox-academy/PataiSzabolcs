using System;
using NUnit.Framework;
using Exercise_1;
using System.Collections.Generic;

namespace TestForExercise_1
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            UniqueChars uniqueChars = new UniqueChars();
            string input = "badassmotherfucker";
            List<char> result = uniqueChars.UniqueCharacters(input);
            List<char> expected = new List<char>() { 'b', 'd', 'm', 'o', 't', 'h', 'f', 'u', 'c', 'k' };
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestMethod2()
        {
            UniqueChars uniqueChars = new UniqueChars();
            string input = "bbbgggglltppppff";
            List<char> result = uniqueChars.UniqueCharacters(input);
            List<char> expected = new List<char>() { 't' };
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestMethod3()
        {
            UniqueChars uniqueChars = new UniqueChars();
            string input = "zzz1ff33k";
            List<char> result = uniqueChars.UniqueCharacters(input);
            List<char> expected = new List<char>() { '1', 'k' };
            Assert.AreEqual(result, expected);
        }
    }
}
