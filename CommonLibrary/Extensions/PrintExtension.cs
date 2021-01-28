using System;
using System.Collections.Generic;
using System.Linq;

namespace CommonLibrary
{
    public static class PrintExtension
    {
        public const string separator = "================================================================";

        public static void WriteLine<T>(IEnumerable<T> items) => Console.WriteLine(items.ToConsoleString());

        public static void WriteLine<T>(T[,] matrix) => Console.WriteLine(matrix.ToConsoleString());

        public static void WriteLine<T>(T value) => Console.WriteLine(value);

        public static void WriteSeparator() => WriteLine(separator);

        private static IEnumerable<IEnumerable<T>> AsEnumerable<T>(this T[,] matrix) =>
            Enumerable.Range(0, matrix.GetLength(0))
                .Select(row => Enumerable.Range(0, matrix.GetLength(1))
                    .Select(col => matrix[row, col]));

        private static string ToConsoleString<T>(this IEnumerable<T> items)
        {
            var str = string.Join(",", items.Select(i => i is IEnumerable<object> t ? t.ToConsoleString() : i.ToString()));
            return "[" + str + "]";
        }

        private static string ToConsoleString<T>(this T[,] matrix) =>
            matrix.AsEnumerable()
                .Select(row => row.ToConsoleString())
                .ToConsoleString();
    }
}
