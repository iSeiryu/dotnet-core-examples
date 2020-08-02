using System;

namespace BasicConsoleProject
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
        }
    }
}
