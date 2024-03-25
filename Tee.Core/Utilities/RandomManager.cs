using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tee.Core.Utilities
{
    public static class RandomManager
    {
        private static readonly Random random = new Random();

        public static int Next(int minValue, int maxValue)
        {
            return random.Next(minValue, maxValue);
        }

        public static T Choose<T>(IList<T> items)
        {
            return items[Next(0, items.Count)];
        }

        public static IEnumerable<T> ChooseSet<T>(IList<T> items, int count)
        {
            return items.OrderBy(x => random.Next()).Take(count);
        }

        public static bool NextBool()
        {
            return Next(0, 2) > 0;
        }

        public static string RandomString(int size)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, size)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static double NextDouble(double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }
    }

}
