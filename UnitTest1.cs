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
        public static string ToCamelCase(string str)
        {
            var separators = new List<char>();

            foreach (var strChar in str)
            {
                if (!char.IsLetter(strChar))
                {
                    separators.Add(strChar);
                }
            }

            string[] words = str.Split(separators.ToArray());

            for (int i = 1; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i][1..];
            }

            string result = string.Join("", words);

            return result;
        }
    }

    [TestFixture]
    public class Tests
    {
        [Test]
        public static void Test1()
        {
            Assert.AreEqual("theStealthWarrior", Kata.ToCamelCase("the_stealth_warrior"), "Kata.ToCamelCase('the_stealth_warrior') did not return correct value");
            Assert.AreEqual("TheStealthWarrior", Kata.ToCamelCase("The-Stealth-Warrior"), "Kata.ToCamelCase('The-Stealth-Warrior') did not return correct value");
        }
    }
}