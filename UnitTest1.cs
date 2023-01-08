using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Codewars
{
    public class Kata
    {
        public static string HighAndLow(string numbers)
        {
            var numbArr = numbers.Split(" ");

            var numbList = new List<int>();

            foreach (var number in numbArr)
            {
                numbList.Add(Convert.ToInt32(number));
            }

            string min = numbList.Min().ToString();
            string max = numbList.Max().ToString();

            return $"{max} {min}";
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", Kata.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
        [Test]
        public void Test2()
        {
            Assert.AreEqual("3 1", Kata.HighAndLow("1 2 3"));
        }
    }
}