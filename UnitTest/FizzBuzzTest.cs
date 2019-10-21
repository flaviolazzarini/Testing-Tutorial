using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestingTutorial;

namespace UnitTest
{
    /// <summary>
    /// Summary description for FizzBuzzTest
    /// </summary>
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ReturnOne()
        {
            FizzBuzz.Compute(-1);
        }

        [TestMethod]
        public void ReturnFifteenCount()
        {
            int n = 15;
            List<string> result = FizzBuzz.Compute(n);
            List<string> expected = new List<string> {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz"
            };
            Assert.AreEqual(expected.Count, result.Count);

        }

        [TestMethod]
        public void ReturnFifteent()
        {
            int n = 15;
            List<string> result = FizzBuzz.Compute(n);
            List<string> expected = new List<string> {
                "1", "2", "Fizz", "4", "Buzz",
                "Fizz", "7", "8", "Fizz", "Buzz",
                "11", "Fizz", "13", "14", "FizzBuzz"
            };
            for (int i = 0; i < n; i++)
            {
                Assert.AreEqual(expected[i], result[i]);
            }

        }
    }
}
