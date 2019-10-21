using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTutorial;

namespace UnitTest
{
    [TestClass]
    public class HelloTest
    {
        [TestMethod]
        public void TestHelloMessage()
        {
            Assert.AreEqual(Hello.HelloMessage(), "Hello World");
        }
    }
}
