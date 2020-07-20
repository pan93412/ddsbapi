using System;
using System.Linq;

namespace ddsbapi
{
    /// <summary>
    /// Consts and some dynamic-generated values.
    /// </summary>
    public static class Consts
    {
        private const string randomSource = "abcdefghijklmnopqrstuvwxyz0123456789";
        private static readonly Random random = new Random();

        /// <summary>
        /// Generate a new random string whose length is 8
        /// and only with digits and lowercase letters.
        /// </summary>
        public static string NewShortenLink => new string(
            Enumerable.Repeat(randomSource, 8)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()
        );
    }
}
