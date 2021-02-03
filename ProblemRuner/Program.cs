using static CommonLibrary.Extensions.ConsoleExtension;
using System;
using System.IO;
using System.Reflection;

namespace ProblemRuner
{
    internal static class Program
    {
        private static void Main()
        {
            Write("Input problem NO: ");
            var no = ReadLine();
            uint index;
            while (string.IsNullOrEmpty(no) || !uint.TryParse(no, out index))
            {
                Clear();
                Write("Input problem NO: ");
                no = ReadLine();
            }

            WriteLine(separator);

            var type = GetSolutionType(index);
            if (type == null)
            {
                WriteLine($"Can't find solution of NO.{index}. Please check it out.");
            }
            else
            {
                Activator.CreateInstance(type);
            }

            ReadKey();
        }

        private static Type GetSolutionType(uint index)
        {
            var assemblyNames = new[]
            {
                "CommonLibrary.dll",
                "P0001ToP0100.dll",
                "P0101ToP0200.dll",
                "P0201ToP0300.dll",
                "P0301ToP0400.dll",
                "P0401ToP0500.dll",
                "P0501ToP0600.dll",
                "P0601ToP0700.dll",
                "P0701ToP0800.dll",
                "P0801ToP0900.dll",
                "P0901ToP1000.dll",
                "P1001ToP1100.dll",
                "P1101ToP1200.dll",
                "P1201ToP1300.dll",
                "P1301ToP1400.dll",
                "P1401ToP1500.dll",
                "P1501ToP1600.dll",
                "P1601ToP1700.dll",
                "P1701ToP1800.dll",
                "P1801ToP1900.dll",
                "P1901ToP2000.dll",
            };
            var className = $"Solution{index:D4}";
            var path = AppDomain.CurrentDomain.BaseDirectory;
            foreach (var assemblyName in assemblyNames)
            {
                Assembly assembly = Assembly.LoadFile(Path.Combine(path, assemblyName));
                foreach (var type in assembly.GetTypes())
                {
                    if (type.IsClass && type.Name == className)
                        return type;
                }
            }
            return null;
        }
    }
}