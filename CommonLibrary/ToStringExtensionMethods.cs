using System.Collections.Generic;
using System.Linq;

namespace CommonLibrary
{
    public static class ToStringExtensionMethods
    {
        public static string ToConsoleString<T>(this IEnumerable<T> items)
        {
            var str = string.Join(",", items.Select(i => i.ToString()));
            return "[" + str + "]";
        }

        public static string ToConsoleString<T>(this T[,] matrix) =>
            matrix.AsEnumerable()
                .Select(row => row.ToConsoleString())
                .ToConsoleString();

        private static IEnumerable<IEnumerable<T>> AsEnumerable<T>(this T[,] matrix) =>
            Enumerable.Range(0, matrix.GetLength(0))
                .Select(row => Enumerable.Range(0, matrix.GetLength(1))
                    .Select(col => matrix[row, col]));
    }
}
