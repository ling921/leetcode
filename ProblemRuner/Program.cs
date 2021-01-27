using System;
using System.IO;
using System.Reflection;

namespace ProblemRuner
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Input problem NO: ");
            var no = Console.ReadLine();
            uint index;
            while (string.IsNullOrEmpty(no) || !uint.TryParse(no, out index))
            {
                Console.Write("Input problem NO: ");
                no = Console.ReadLine();
            }

            Console.WriteLine("============================\r\nResult: ");

            var type = GetSolutionType(index);
            if (type == null)
                Console.WriteLine($"Can't find solution of NO.{index}. Please check it out.");
            else
                Activator.CreateInstance(type);

            Console.ReadKey();
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
