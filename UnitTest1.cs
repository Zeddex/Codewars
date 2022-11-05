using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using NUnit.Framework;

namespace Codewars
{
    public class Kata
    {
        public static bool Scramble(string str1, string str2)
        {
            var str1Arr = str1.ToCharArray();

            foreach (var chr in str2)
            {
                if (!str1Arr.Contains(chr))
                {
                    return false;
                }

                str1Arr[Array.IndexOf(str1Arr, chr)] = '-';
            }

            return true;
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(true, Kata.Scramble("rkqodlw", "world"));
            Assert.AreEqual(true, Kata.Scramble("cedewaraaossoqqyt", "codewars"));
            Assert.AreEqual(false, Kata.Scramble("katas", "steak"));
            Assert.AreEqual(false, Kata.Scramble("scriptjavx", "javascript"));
            Assert.AreEqual(true, Kata.Scramble("scriptingjava", "javascript"));
            Assert.AreEqual(true, Kata.Scramble("scriptsjava", "javascripts"));
            Assert.AreEqual(false, Kata.Scramble("javscripts", "javascript"));
            Assert.AreEqual(true, Kata.Scramble("aabbcamaomsccdd", "commas"));
            Assert.AreEqual(true, Kata.Scramble("commas", "commas"));
            Assert.AreEqual(true, Kata.Scramble("sammoc", "commas"));
        }
    }
}