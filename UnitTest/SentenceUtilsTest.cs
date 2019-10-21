using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTutorial;

namespace UnitTest
{
    [TestClass]
    public class SentenceUtilsTest
    {
        [TestMethod]
        public void Character()
        {
            Assert.AreEqual("A", SentenceUtils.ToTitleCase("a"));
        }

        [TestMethod]
        public void WordAllLowerCase()
        {
            Assert.AreEqual("Abc", SentenceUtils.ToTitleCase("abc"));
        }

        [TestMethod]
        public void WordAllUppercase()
        {
            Assert.AreEqual("Abc", SentenceUtils.ToTitleCase("ABC"));
        }

        [TestMethod]
        public void WordRandomUppercase()
        {
            Assert.AreEqual("Abc", SentenceUtils.ToTitleCase("aBC"));
        }

        [TestMethod]
        public void Word()
        {
            Assert.AreEqual("Abc", SentenceUtils.ToTitleCase("Abc"));
        }

        [TestMethod]
        public void Sentence()
        {
            Assert.AreEqual("Abc Def Ghi", SentenceUtils.ToTitleCase("abc def ghi"));
        }

        [TestMethod]
        public void MultipleWhitespace()
        {
            Assert.AreEqual("  Abc  Def Ghi ", SentenceUtils.ToTitleCase("  abc  def ghi "));
        }
    }
}
