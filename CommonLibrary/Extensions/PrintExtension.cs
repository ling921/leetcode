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

        public static void WriteLine<T>(T[][] array) => Console.WriteLine(array.ToConsoleString());

        public static void WriteLine(string value) => Console.WriteLine(value);

        public static void WriteLine<T>(T value) where T : struct => Console.WriteLine(value);

        public static void WriteSeparator() => WriteLine(separator);

        private static IEnumerable<IEnumerable<T>> AsEnumerable<T>(this T[,] matrix) =>
            Enumerable.Range(0, matrix.GetLength(0))
                .Select(row => Enumerable.Range(0, matrix.GetLength(1))
                    .Select(col => matrix[row, col]));

        private static string ToConsoleString<T>(this IEnumerable<T> items)
        {
            var str = string.Join(",", items.Select(i => i.ToString()));
            return "[" + str + "]";
        }

        private static string ToConsoleString<T>(this T[,] matrix) => matrix
            .AsEnumerable()
            .Select(row => row.ToConsoleString())
            .ToConsoleString();

        private static string ToConsoleString<T>(this T[][] array) => array
            .Select(arr => arr.ToConsoleString())
            .ToConsoleString();
    }
}
