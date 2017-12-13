using NUnit.Framework;
using System.Collections.Generic;

namespace Extension
{
    [TestFixture]
    public class ExtensionTests
    {
        Extension extension = new Extension();

        [Test]
        public void TestAdd_2and3is5()
        {
            Assert.AreEqual(5, extension.Add(2, 3));
        }

        [Test]
        public void TestAdd_1and4is5()
        {
            Assert.AreEqual(5, extension.Add(1, 4));
        }

        [Test]
        public void TestMaxOfThree_First()
        {
            Assert.AreEqual(5, extension.MaxOfThree(5, 4, 3));
        }

        [Test]
        public void TestMaxOfThree_Fhird()
        {
            Assert.AreEqual(5, extension.MaxOfThree(3, 4, 5));
        }

        [Test]
        public void TestMedian_Four()
        {
            Assert.AreEqual(5, extension.Median(new List<int>() { 7, 5, 3, 5 }));
        }

        [Test]
        public void TestMedian_Five()
        {
            Assert.AreEqual(3, extension.Median(new List<int>() { 1, 2, 3, 4, 5 }));
        }

        [Test]
        public void TestIsVowel_a()
        {
            Assert.True(extension.IsVowel('a'));
        }

        [Test]
        public void TestIsVowel_u()
        {
            Assert.True(extension.IsVowel('u'));
        }

        [Test]
        public void testTranslate_bemutatkozik()
        {
            Assert.AreEqual("bevemuvutavatkovozivik", extension.Translate("bemutatkozik"));
        }

        [Test]
        public void testTranslate_kolbice()
        {
            Assert.AreEqual("lavagovopuvus", extension.Translate("lagopus"));
        }
        [Test]
        public void TestAdd([Values(1, 2, 3, 4, 5, 6, 7)] int number)
        {
            int input1 = number;
            int input2 = number;
            Assert.AreEqual(input1 + input2, extension.Add(input1, input2));
        }

        [Test]
        public void TestMaxOfThree_Fourth()
        {
            Assert.AreEqual(2, extension.MaxOfThree(2, 2, 1));
        }

        [Test]
        public void TestMaxOfThree_Second()
        {
            Assert.AreEqual(3, extension.MaxOfThree(2, 1, 3));
        }

        [Test]
        public void TestMaxOfThree_Third2()
        {
            Assert.AreEqual(11, extension.MaxOfThree(5, 11, 8));
        }

        [Test]
        public void TestMedian_Four2()
        {
            Assert.AreEqual(8, extension.Median(new List<int>() { 1, 6, 10, 10 }));
        }

        [Test]
        public void TestMedian_Five2()
        {
            Assert.AreEqual(13, extension.Median(new List<int>() { 1, 5, 13, 15, 166 }));
        }

        [Test]
        public void TestIsVowel_ü()
        {
            Assert.True(extension.IsVowel('ü'));
        }

        [Test]
        public void testTranslate_ütközik()
        {
            Assert.AreEqual("üvütkövözivik", extension.Translate("ütközik"));
        }        
    }
}
