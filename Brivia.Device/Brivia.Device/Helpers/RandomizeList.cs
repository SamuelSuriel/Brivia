using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brivia.Device.Helpers
{
    public static class RandomizeList
    {
        public static IEnumerable<T> Randomize<T>(this IEnumerable<T> source)
        {
            Random rnd = new Random();
            return source.OrderBy<T, int>((item) => rnd.Next());
        }
    }
}
