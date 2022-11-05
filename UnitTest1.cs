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
        public static long NextBiggerNumber(long n)
        {
            var variations = PermuteInput(n.ToString().ToCharArray()).Distinct().ToArray();

            if (variations.Length == 1)
            {
                return -1;
            }

            var numbVariations = Array.ConvertAll(variations, s => long.Parse(s));

            Array.Sort(numbVariations);
            int index = Array.IndexOf(numbVariations, n);

            if (index == numbVariations.Length)
            {
                return -1;
            }

            long nextNumber = numbVariations[index + 1];

            return nextNumber;
        }

        public static string[] PermuteInput(char[] digits)
        {
            bool[] used = new bool[digits.Length];
            List<string> list = new List<string>();
            string resultNumber = "";

            Permute(digits, used, resultNumber, 0, list);

            return list.ToArray();
        }

        private static void Permute(char[] digits, bool[] used, string resultNumber, int level, List<string> list)
        {
            if (level == digits.Length && resultNumber != "")
            {
                list.Add(resultNumber);

                return;
            }

            for (int i = 0; i < digits.Length; i++)
            {
                if (used[i])
                    continue;

                used[i] = true;

                Permute(digits, used, resultNumber + digits[i], level + 1, list);

                used[i] = false;
            }
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual(21, Kata.NextBiggerNumber(12));
            Assert.AreEqual(531, Kata.NextBiggerNumber(513));
            Assert.AreEqual(2071, Kata.NextBiggerNumber(2017));
            Assert.AreEqual(441, Kata.NextBiggerNumber(414));
            Assert.AreEqual(414, Kata.NextBiggerNumber(144));
        }
    }
}