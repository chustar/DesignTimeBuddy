using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace DesignTimeBuddy
{
    public class DeisgnTimeBuddy
    {
        private static string loremIpsum = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";

        public static string GetSimpleString(int wordLength = 10)
        {
            return GetWords(loremIpsum, wordLength);
        }

        private static string GetWords(string source, int wordLength)
        {
            var words = source.Split(' ');
            string result = "";
            foreach (var word in words.Skip(randomizer.Next(words.Length / 2)).Take(wordLength < words.Count() ? wordLength : words.Count()))
            {
                result += word + " ";
            }
            return Regex.Replace(result, "[^a-zA-Z0-9 ]", "");
        }

        private int GetPseudoRandomNumber(int max)
        {
            return DateTime.Now.Millisecond % max;
        }

        private static Random randomizer = new Random();
    }
}
