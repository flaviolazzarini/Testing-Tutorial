using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingTutorial
{
    public class FizzBuzz
    {
        /// <summary>
        /// an array with the numbers from 1 to n with the following restrictions:
        /// * for multiples of 3 store "Fizz" instead of the number
        /// * for multiples of 5 store "Buzz" instead of the number
        /// * for numbers which are multiples of both 3 and 5 store "FizzBuzz"
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static List<string> Compute(int n)
        {
            return Enumerable.Range(1, n)
                .Select(a => String.Format("{0}{1}",
                                           a % 3 == 0 ? "Fizz" : string.Empty,
                                           a % 5 == 0 ? "Buzz" : string.Empty))
                .Select((b, i) => String.IsNullOrEmpty(b) ? (i + 1).ToString() : b)
                .ToList();
        }
    }
}
