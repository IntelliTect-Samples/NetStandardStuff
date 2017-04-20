using System;

namespace SampleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"StandardLibrary Method Output: { StandardLibrary.Thing.Method() }");
        }
    }
}